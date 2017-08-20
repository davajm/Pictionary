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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public main()
        {
            ep = new ErrorProvider();
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            InitializeComponent();
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
            if (txtJoinIP.TextLength <= 0)
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
                this.Invoke((MethodInvoker)delegate
                {
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

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '*')
            {
                e.Handled = true;
            }
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            headerText.Text = "Join game";
            panelJoinGame.Visible = panelJoinGame.Enabled = true;
            panelHostGame.Visible = panelHostGame.Enabled = false;
            btnJoinGame.BackColor = Color.FromArgb(56, 73, 91);
            btnQuit.BackColor = btnHostGame.BackColor = btnSettings.BackColor = Color.FromArgb(41, 53, 65);
        }

        private void btnHostGame_Click(object sender, EventArgs e)
        {
            headerText.Text = "Host game";
            panelHostGame.Visible = panelHostGame.Enabled = true;
            panelJoinGame.Visible = panelJoinGame.Enabled = false;
            btnHostGame.BackColor = Color.FromArgb(56, 73, 91);
            btnQuit.BackColor = btnSettings.BackColor = btnJoinGame.BackColor = Color.FromArgb(41, 53, 65);
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            headerText.Text = "Settings";
            panelHostGame.Visible = panelHostGame.Enabled = false;
            panelJoinGame.Visible = panelJoinGame.Enabled = false;
            btnSettings.BackColor = Color.FromArgb(56, 73, 91);
            btnQuit.BackColor = btnHostGame.BackColor = btnJoinGame.BackColor = Color.FromArgb(41, 53, 65);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Exit program", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimizeclick;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.closeclick;
        }
    }
}
