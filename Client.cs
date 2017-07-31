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
        // Client
        Socket client;
        string userName;

        private byte[] byteData = new byte[1024];

        // Drawing stuff
        private Graphics g;
        List<List<Point>> allStrokes;  // All strokesk user has drawn
        List<Point> currentStroke;     // Current stroke user is drawing

        bool mouseDown, isDrawing;

        public Client(string userName, Socket client)
        {
            this.userName = userName;
            this.client = client;
            byteData = new byte[1024];
            SendMessage(null, Command.Login);
            InitializeComponent();
            allStrokes = new List<List<Point>>();
            mouseDown = false;
            g = drawingBoard.CreateGraphics();
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
                Data msgReceived;
                msgReceived = new Data(byteData, false);
                if (msgReceived.cmdCommand == Command.Stroke || msgReceived.cmdCommand == Command.NewStroke)
                {
                    msgReceived = new Data(byteData, true);
                }
                //Accordingly process the message received
                switch (msgReceived.cmdCommand)
                {
                    // If a new user has connected
                    case Command.Login:
                        playerList.Invoke((MethodInvoker)delegate {
                            playerList.AddPlayer(msgReceived.strName);
                        });
                        chat.Invoke((MethodInvoker)delegate {
                            chat.Text += msgReceived.strName + " has joined the room\r\n";
                        });
                        break;

                    // If a user has disconnected
                    case Command.Logout:
                        playerList.Invoke((MethodInvoker)delegate
                        {
                            playerList.RemovePlayer(msgReceived.strName);
                        });
                        chat.Invoke((MethodInvoker)delegate {
                            chat.Text += msgReceived.strName + " has left the room\r\n";
                        });
                        break;
                    case Command.NewStroke:
                        drawingBoard.Invoke((MethodInvoker)delegate
                        {
                            currentStroke = new List<Point>();
                            currentStroke.Add(msgReceived.p1);
                            allStrokes.Add(currentStroke);
                            drawingBoard.Invalidate();
                        });
                        break;
                    case Command.Stroke:
                        drawingBoard.Invoke((MethodInvoker)delegate
                        {
                            currentStroke.Add(msgReceived.p1);
                            drawingBoard.Invalidate();
                        });
                        break;
                    case Command.Message:
                        break;
                    case Command.Ready:
                        playerList.Invoke((MethodInvoker)delegate
                        {
                            playerList.Ready(msgReceived.strName);
                        });
                        break;

                    case Command.List:
                        playerList.Invoke((MethodInvoker)delegate
                        {
                            string[] names = msgReceived.strMessage.Split('*');
                            for (int i = 0; i < names.Length-2; i++)
                            {
                                playerList.AddPlayer(names[i]);
                            }
                            playerList.AddPlayer(userName);
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
                if (input.TextLength > 0)
                {
                    SendMessage(input.Text, Command.Message);
                    input.Clear();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // Start receiving from server when client has loaded

            // Get list of players
            SendMessage(null, Command.List);

            // Begin listening
            client.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            SendMessage(null, Command.Ready);
        }


        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            // Mouse is down, start a new stroke
            currentStroke = new List<Point>();

            // Add current position to stroke
            currentStroke.Add(e.Location);

            // Add stroke to the list
            allStrokes.Add(currentStroke);
            try
            {
                //Fill the info for the message to be send
                Data msgToSend = new Data();

                msgToSend.cmdCommand = Command.NewStroke;
                msgToSend.strName = userName;
                msgToSend.size = 0;
                msgToSend.shape = 0;
                msgToSend.p1 = e.Location;
                msgToSend.color = Color.Black;

                byte[] byteData = msgToSend.DrawingToByte();

                //Send it to the server
                client.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to send message to the server.", "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

            if (mouseDown)
            {
                currentStroke.Add(e.Location);
                drawingBoard.Invalidate();
                try
                {
                    //Fill the info for the message to be send
                    Data msgToSend = new Data();

                    msgToSend.cmdCommand = Command.Stroke;
                    msgToSend.strName = userName;
                    msgToSend.size = 0;
                    msgToSend.shape = 0;
                    msgToSend.p1 = e.Location;
                    msgToSend.color = Color.Black;

                    byte[] byteData = msgToSend.DrawingToByte();

                    //Send it to the server
                    client.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to send message to the server.", "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Pictionary", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                //Send a message to logout of the server
                Data msgToSend = new Data();
                msgToSend.cmdCommand = Command.Logout;
                msgToSend.strName = userName;
                msgToSend.strMessage = null;

                byte[] b = msgToSend.ToByte();
                client.Send(b, 0, b.Length, SocketFlags.None);
                client.Close();
            }
            catch (ObjectDisposedException)
            {}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pictionary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            foreach (List<Point> stroke in allStrokes.Where(x => x.Count > 1))
                e.Graphics.DrawLines(System.Drawing.Pens.Black, stroke.ToArray());
        }
    }
}