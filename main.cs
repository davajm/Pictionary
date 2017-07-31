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
    public partial class main : Form
    {
        ErrorProvider ep;
        Socket client;
        Server server;
        string username;
    
        public main()
        {
            ep = new ErrorProvider();
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            InitializeComponent();
        }

        private void btnHostGame_Click(object sender, EventArgs e)
        {
            grpJoinGame.Enabled = grpJoinGame.Visible = false;
            grpHostGame.Enabled = grpHostGame.Visible = true;
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            grpHostGame.Enabled = grpHostGame.Visible = false;
            grpJoinGame.Enabled = grpJoinGame.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Exit program", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            grpHostGame.Enabled = grpHostGame.Visible = false;
            grpJoinGame.Enabled = grpJoinGame.Visible = false;
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            int errors = 0;
            ep.Clear();

            if (txtHostName.TextLength <= 0)
            {
                ep.SetError(txtHostName, "Please provide a name");
                errors++;
            }
            if (txtHostPort.TextLength <= 0)
            {
                ep.SetError(txtHostPort, "Please provide a port number");
                errors++;
            }

            if (errors > 0)
            {
                return;
            }
            username = txtHostName.Text;
            server = new Server(Int32.Parse(txtHostPort.Text));
            ConnectToServer("", Int32.Parse(txtHostPort.Text));
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            int errors = 0;
            ep.Clear();
            if (txtJoinName.TextLength <= 0)
            {
                ep.SetError(txtJoinName, "Please provide a name");
                errors++;
            }
            if(txtJoinIP.TextLength <= 0)
            {
                ep.SetError(txtJoinIP, "Please provide an IP address");
                errors++;
            }
            if (txtJoinPort.TextLength <= 0)
            {
                ep.SetError(txtJoinPort, "Please provide a port number");
                errors++;
            }   
            if (errors > 0)
            {
                return;
            }
            username = txtJoinName.Text;
            ConnectToServer(txtJoinIP.Text, Int32.Parse(txtJoinPort.Text));
        }

        private void IntOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ConnectToServer(string ip, int port)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ipAddress;
                if (ip == "")
                {
                    ipAddress = IPAddress.Parse("127.0.0.1");
                }
                else
                {
                    ipAddress = IPAddress.Parse(ip);
                }

                //Server is listening on port 1000
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);

                //Connect to the server
                client.BeginConnect(ipEndPoint, new AsyncCallback(OnConnect), null);
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
                this.Invoke((MethodInvoker)delegate {
                    Client c = new Client(username, client);
                    this.Hide();
                    c.ShowDialog();
                    if (server != null)
                    {
                        server.StopServer();
                    }
                    this.Show();
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pictionary2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
