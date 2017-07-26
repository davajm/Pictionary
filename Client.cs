using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Pictionary
{
    public partial class Client : Form
    {
        // Server
        bool isServer;
        Server server;

        // Client
        Socket client;
        string userName;

        private byte[] byteData = new byte[1024];


        public Client(bool isServer, string userName)
        {
            this.isServer = isServer;
            this.userName = userName;
            if (isServer)
            {
                server = new Server();
            }
            byteData = new byte[1024];
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

                //Server is listening on port 1000
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 1000);

                //Connect to the server
                client.BeginConnect(ipEndPoint, new AsyncCallback(OnConnect), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSend(IAsyncResult ar)
        {
            try
            {
                client.EndSend(ar);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnConnect(IAsyncResult ar)
        {
            try
            {
                client.EndConnect(ar);
                SendMessage(null, Command.Login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendMessage(string message, Command command)
        {
            try
            {
                //Fill the info for the message to be send
                Data msgToSend = new Data();

                msgToSend.strName = userName;
                msgToSend.strMessage = message;
                msgToSend.cmdCommand = command;

                byte[] byteData = msgToSend.ToByte();

                //Send it to the server
                client.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to send message to the server.", "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                client.EndReceive(ar);

                Data msgReceived = new Data(byteData);
                //Accordingly process the message received
                switch (msgReceived.cmdCommand)
                {
                    // If a new user has connected
                    case Command.Login:
                        playerList.Invoke((MethodInvoker)delegate {
                            playerList.Items.Add(msgReceived.strName);
                        });
                        break;

                    // If a user has disconnected
                    case Command.Logout:
                        playerList.Invoke((MethodInvoker)delegate {
                            playerList.Items.Remove(msgReceived.strName);
                        });
                        break;

                    case Command.Message:
                        break;

                    case Command.List:
                        playerList.Invoke((MethodInvoker)delegate {
                            playerList.Items.AddRange(msgReceived.strMessage.Split('*'));
                            playerList.Items.RemoveAt(playerList.Items.Count - 1);
                        });
                        chat.Invoke((MethodInvoker)delegate {
                            chat.Text += "<<<" + msgReceived.strName + " has joined the room>>>\r\n";
                        });
                        break;
                }

                if (msgReceived.strMessage != null && msgReceived.cmdCommand != Command.List)
                    chat.Invoke((MethodInvoker)delegate {
                        chat.Text += msgReceived.strMessage + "\r\n";
                    });

                byteData = new byte[1024];

                client.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);

            }
            catch (ObjectDisposedException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage(input.Text, Command.Message);
                input.Clear();
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // Get list of players when the client has loaded
            SendMessage(null, Command.List);

            // Start receiving from server
            client.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
        }
    }
}
