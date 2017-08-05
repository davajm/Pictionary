using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Pictionary
{
    class Server
    {
        public class ClientInfo
        {
            public Socket socket;   // Socket of the client
            public string strName;  // Username
            public bool isReady;    // Ready for game sta
            public int score;       // User score
            public bool isDrawing;  // Determines if the user is currently drawing
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


        public Server(int port)
        {
            clients = new List<ClientInfo>();
            state = State.WaitingForPlayers;
            StartServer(port);
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
        private void NewGame(int rounds, int time)
        {
            for (int i = 0; i < rounds; i++)
            {
                foreach (ClientInfo client in clients)
                {
                    client.isDrawing = true;

                    Data msgToSend = new Data();
                    byte[] message;

                    msgToSend.cmdCommand = Command.StartDrawing;
                    msgToSend.strMessage = null;
                    msgToSend.strName = client.strName;

                    message = msgToSend.ToByte();

                    foreach (ClientInfo clientInfo in clients)
                    {
                        if (client != clientInfo)
                        {
                            client.isDrawing = false;
                        }
                        //Send the message to all users
                        clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(OnSend), clientInfo.socket);
                    }
                    Thread.Sleep(time*1000);
                }
            }
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
                        clientInfo.isDrawing = false;

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
                            if (msgReceived.strMessage == currentWord)
                            {
                                correctWord = true;
                            }                       
                        }
                        // Set the broadcast message (if not correct guess)
                        if (!correctWord)
                        {
                            //Set the text of the message that we will broadcast to all
                            msgToSend.strMessage = msgReceived.strName + ": " + msgReceived.strMessage;
                        }
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

                if (msgToSend.cmdCommand != Command.List && msgToSend.cmdCommand != Command.NewStroke && msgToSend.cmdCommand != Command.Stroke)   //List messages are not broadcasted
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
                            NewGame(10, 10);
                        }
                    }
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


