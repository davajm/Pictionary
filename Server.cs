using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Diagnostics;
using System.IO;

namespace Pictionary
{
    class Server
    {
        public class ClientInfo
        {
            public Socket socket;   // Socket of the client
            public string strName;  // Username
            public bool isReady;    // Ready for game start
            public bool isDrawing;  // If user is drawing
            public int score;       // User score
            public bool hasGuessed; // If user has guessed correct this round
        }
        enum State
        {
            WaitingForPlayers,
            ChoosingWord,
            Drawing
        }

        List<ClientInfo> clients; 
        Socket server;
        byte[] byteData = new byte[1024];
        State state;
        string currentWord;
        int[] hintIndexes;
        int currentScore;
        bool broadcastMessage;
        string[] words;
        Random random;
        System.Timers.Timer hintTimer;
        int givenHints;
        System.Timers.Timer timer;
        bool timeLowered;
        Stopwatch sw;


        ManualResetEvent mre;

        public Server(int port)
        {
            clients = new List<ClientInfo>();
            state = State.WaitingForPlayers;
            StartServer(port);
            random = new Random();
            words = File.ReadAllLines("words.txt");
            mre = new ManualResetEvent(false);
        }
        private void StartServer(int port)
        {
            try
            {
                //We are using TCP sockets
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //Assign the any IP of the machine and listen on provided port
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, port);

                //Bind and listen on the given address
                server.Bind(ipEndPoint);
                server.Listen(4);

                //Accept the incoming clients
                server.BeginAccept(new AsyncCallback(OnAccept), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopServer()
        {
            for (int i = clients.Count-1; i >= 0; i--)
            {
                clients[i].socket.Close();
            }
            server.Close();
        }

        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = server.EndAccept(ar);

                //Start listening for more clients
                server.BeginAccept(new AsyncCallback(OnAccept), null);

                //Once the client connects then start receiving the commands from her
                clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
            }
            catch (ObjectDisposedException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void OnSend(IAsyncResult ar)
        {
            try
            {                
                Socket client = (Socket)ar.AsyncState;
                client.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Function to start a new game
        /// </summary>
        /// <param name="rounds"> Amount of rounds </param>
        /// <param name="time"> Time per round in seconds </param>
        private async Task NewGame()
        {
            int rounds = 3;

            timer = new System.Timers.Timer();
            hintTimer = new System.Timers.Timer();
            Data msgToSend = new Data();
            byte[] message;
            for (int i = 0; i < rounds; i++)
            {
                foreach (ClientInfo client in clients)
                {
                    state = State.ChoosingWord;
                    currentWord = null;
                    currentScore = 100;

                    msgToSend.cmdCommand = Command.ChooseWord;
                    msgToSend.strMessage = null;
                    msgToSend.strName = client.strName;

                    message = msgToSend.ToByte();
                    await Task.Delay(1);

                    // Broadcast that player is choosing word
                    foreach (ClientInfo clientInfo in clients)
                    {
                        clientInfo.hasGuessed = false;
                        if (client != clientInfo)
                        {
                            clientInfo.isDrawing = false;
                            clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
                        }
                    }

                    // Generate 3 random words
                    msgToSend.strMessage = words[random.Next(0, words.Length-1)].ToUpper();
                    msgToSend.strMessage += "*" + words[random.Next(0, words.Length - 1)].ToUpper();
                    msgToSend.strMessage += "*" + words[random.Next(0, words.Length - 1)].ToUpper();
                    message = msgToSend.ToByte();

                    // Tell player to choose word
                    client.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), client.socket);
                    msgToSend.strMessage = null;

                    // Wait for player to choose word
                    mre.Reset();
                    mre.WaitOne();

                    // Tell player to start drawing
                    client.isDrawing = true;
                    msgToSend.cmdCommand = Command.StartDrawing;
                    msgToSend.strMessage = currentWord.Length.ToString();
                    message = msgToSend.ToByte();
                    foreach (ClientInfo clientInfo in clients)
                    {
                        //Send the message to all users
                        clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
                    }
                    state = State.Drawing;
                    timeLowered = false;

                    // Wait for timer or all users to guess correctly
                    timer.Interval = 90000;
                    timer.Elapsed += ResetTimer;
                    timer.AutoReset = false;
                    timer.Enabled =  true;
                    sw = new Stopwatch();
                    sw.Start();

                    // Hint mechanics
                    if (currentWord.Length > 2) // Only provide hints if the word has 2 or more characters
                    {
                        // Hints are given based on the length of the word.
                        // 90 seconds (round time) divided by the length of the word minus 1.
                        // A word of length 4 would give a character hint every 30 seconds.
                        hintTimer.Interval = 90000 / (currentWord.Length - 1);
                        hintTimer.Elapsed += GiveHint;
                        hintTimer.AutoReset = true;
                        hintTimer.Enabled = true;
                    }
                    mre.Reset();
                    mre.WaitOne();
                    state = State.ChoosingWord;
                    timer.Enabled = false;
                    hintTimer.Enabled = false;

                    // Tell players the round is over
                    msgToSend.cmdCommand = Command.RoundOver;
                    msgToSend.strMessage = currentWord;
                    message = msgToSend.ToByte();
                    foreach (ClientInfo clientInfo in clients)
                    {
                        //Send the message to all users
                        clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
                    }

                    timer.Interval = 10000;
                    timer.Elapsed += ResetTimer;
                    timer.AutoReset = false;
                    timer.Enabled = true;

                    mre.Reset();
                    mre.WaitOne();
                    timer.Enabled = false;
                }
            }

            // Tell users the game is over and show end scren.
            msgToSend.cmdCommand = Command.GameOver;
            msgToSend.strMessage = null;
            msgToSend.strName = null;
            message = msgToSend.ToByte();
            foreach (ClientInfo clientInfo in clients)
            {
                //Send the message to all users
                clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
            }
            timer.Interval = 10000;
            timer.Elapsed += ResetTimer;
            timer.AutoReset = false;
            timer.Enabled = true;

            mre.Reset();
            mre.WaitOne();
            timer.Enabled = false;

            // Tell users to ready up again
            msgToSend.cmdCommand = Command.GameOverFinal;
            msgToSend.strMessage = null;
            msgToSend.strName = null;
            message = msgToSend.ToByte();
            foreach (ClientInfo clientInfo in clients)
            {
                //Send the message to all users
                clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
            }

            // Switch state to waiting for players.
            state = State.WaitingForPlayers;
            foreach (ClientInfo client in clients)
            {
                client.isReady = client.isDrawing =  client.hasGuessed = false;
                client.score = 0;
            }
        }
        private void GiveHint(object sender, ElapsedEventArgs e)
        {
            Data msgToSend = new Data();
            byte[] message;

            // Generate an unique index
            int randomIndex = random.Next(0, currentWord.Length);
            while (hintIndexes[randomIndex] == 1)
            {
                randomIndex = random.Next(0, currentWord.Length);
            }
            hintIndexes[randomIndex] = 1;

            // Send hint
            msgToSend.cmdCommand = Command.WordHint;
            msgToSend.strMessage = currentWord[randomIndex] + randomIndex.ToString();
            message = msgToSend.ToByte();
            foreach (ClientInfo clientInfo in clients)
            {
                // Send message to users that are guessing
                if (!clientInfo.isDrawing)
                    clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
            }
            if (givenHints == currentWord.Length-2)
            {
                hintTimer.Enabled = false;
            }
        }
        private void ResetTimer(object sender, ElapsedEventArgs e)
        {
            mre.Set();
        }
        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                //Transform the array of bytes received from the user into an
                //intelligent form of object Data
                Data msgReceived = new Data(byteData, false);
                //We will send this object in response the users request

                Data msgToSend = new Data();

                byte[] message;

                //If the message is to login, logout, or simple text message
                //then when send to others the type of the message remains the same
                msgToSend.cmdCommand = msgReceived.cmdCommand;
                msgToSend.strName = msgReceived.strName;
                broadcastMessage = true;

                bool newDrawer = false;

                switch (msgReceived.cmdCommand)
                {
                    case Command.Login:

                        //When a user logs in to the server then we add her to our
                        //list of clients

                        ClientInfo clientInfo = new ClientInfo();
                        clientInfo.socket = clientSocket;
                        clientInfo.strName = msgReceived.strName;
                        clientInfo.score = 0;
                        clientInfo.isReady = false;

                        clients.Add(clientInfo);
                        break;

                    case Command.Logout:

                        //When a user wants to log out of the server then we search for her 
                        //in the list of clients and close the corresponding connection
                        for (int i = clients.Count-1; i >= 0; i--)
                        {
                            if (clients[i].socket == clientSocket)
                            {
                                clients.RemoveAt(i);
                                break;
                            }
                        }
                        clientSocket.Close();
                        break;

                    case Command.Message:
                        bool correctWord = false;

                        // Check for correct word if we are playing
                        if (state == State.Drawing)
                        {
                            if (msgReceived.strMessage.ToUpper() == currentWord.ToUpper())
                            {
                                correctWord = true;

                                if (!timeLowered)
                                {
                                    sw.Stop();
                                    if (sw.ElapsedMilliseconds < 60000)
                                    {
                                        timer.Stop();
                                        timer.Interval = 30000;
                                        timer.Start();
                                    }
                                    timeLowered = true;
                                }

                                foreach (ClientInfo client in clients)
                                {
                                    if (client.strName == msgReceived.strName && !client.hasGuessed && !client.isDrawing) 
                                    {
                                        client.hasGuessed = true;
                                        client.score += currentScore;
                                        msgToSend.strName = msgReceived.strName;
                                        msgToSend.strMessage = currentScore.ToString();
                                        msgToSend.cmdCommand = Command.CorrectGuess;
                                        currentScore -= 100 / (clients.Count - 1);
                                        broadcastMessage = true;


                                        // Check if all players have guessed correctly
                                        newDrawer = true;
                                        foreach (ClientInfo c in clients)
                                        {
                                            if (!c.hasGuessed && !c.isDrawing)
                                            {
                                                newDrawer = false;
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        broadcastMessage = false;
                                    }
                                }
                            }                       
                        }
                        // Set the broadcast message (if not correct guess)
                        if (!correctWord)
                        {
                            //Set the text of the message that we will broadcast to all
                            msgToSend.strMessage = msgReceived.strName + ": " + msgReceived.strMessage;
                        }
                        break;
                    case Command.ChooseWord:
                        currentWord = msgReceived.strMessage;
                        givenHints = 0;
                        hintIndexes = new int[currentWord.Length];
                        for (int i = 0; i<currentWord.Length; i++)
                        {
                            hintIndexes[i] = 0;
                        }
                        mre.Set();
                        msgToSend.strMessage = null;
                        msgToSend.strName = null;
                        msgToSend.cmdCommand = Command.Clear;
                        break;
    
                    case Command.Ready:
                        for (int i = clients.Count-1; i >= 0; i--)
                        {
                            if (clients[i].socket == clientSocket)
                            {
                                clients[i].isReady = !clients[i].isReady;
                                break;
                            }
                        }
                        break;
                    case Command.NewStroke:
                    case Command.Stroke:
                        //intelligent form of object Data
                        Data rec = new Data(byteData, true);

                        byte[] msg = rec.DrawingToByte();

                        foreach (ClientInfo client in clients)
                        {
                            if (client.socket != clientSocket)
                            {
                                //Broadcast the message to all users
                                client.socket.BeginSend(msg, 0, msg.Length, SocketFlags.None, new AsyncCallback(OnSend), client.socket);
                            }
                        }
                        break;
                    case Command.List:

                        //Send the names of all users in the chat room to the new user
                        msgToSend.cmdCommand = Command.List;
                        msgToSend.strName = null;
                        msgToSend.strMessage = null;

                        //Collect the names of the user in the chat room
                        foreach (ClientInfo client in clients)
                        {
                            //To keep things simple we use asterisk as the marker to separate the user names
                            msgToSend.strMessage += client.strName + "*";
                        }

                        message = msgToSend.ToByte();

                        //Send the name of the users in the chat room
                        clientSocket.BeginSend(message, 0, message.Length, SocketFlags.None,
                                new AsyncCallback(OnSend), clientSocket);
                        break;
                }

                if (msgToSend.cmdCommand != Command.List && msgToSend.cmdCommand != Command.NewStroke && msgToSend.cmdCommand != Command.Stroke && broadcastMessage)   //Not all messages are broadcasted
                {
                    message = msgToSend.ToByte();

                    foreach (ClientInfo clientInfo in clients)
                    {
                        if (clientInfo.socket != clientSocket ||
                            msgToSend.cmdCommand != Command.Login)
                        {
                            //Send the message to all users
                            clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
                        }
                    }
                }

                //If the user is logging out then we need not listen from her
                if (msgReceived.cmdCommand != Command.Logout)
                {
                    //Start listening to the message send by the user
                    clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
                }

                // If we're waiting for players to get ready (lobby)
                if (state == State.WaitingForPlayers)
                {
                    bool startGame = true;
                    
                    // If atleast two players are connected
                    if (clients.Count > 1)
                    {
                        // Check if all connected players are ready
                        foreach (ClientInfo client in clients)
                        {
                            if (!client.isReady)
                            {
                                startGame = false;
                                break;
                            }
                        }
                        // Start new game
                        if (startGame) 
                        {
                            msgToSend.cmdCommand = Command.StartGame;
                            msgToSend.strMessage = null;
                            msgToSend.strName = null;
                            message = msgToSend.ToByte();

                            foreach (ClientInfo clientInfo in clients)
                            {
                                //Send the message to all users
                                clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
                            }

                            // Change state
                            state = State.Drawing;
                            Task.Run(NewGame);
                        }
                    }
                }
                if (newDrawer && state == State.Drawing)
                {
                    mre.Set();
                }
            }
            catch (ObjectDisposedException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


