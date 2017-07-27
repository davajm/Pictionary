using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictionary
{
    public partial class main : Form
    {
        ErrorProvider ep;
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

            Client ng = new Client(true, txtHostName.Text, "", Int32.Parse(txtHostPort.Text));
            ng.Show();
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
            if (txtJoinPort.TextLength <= 0)
            {
                ep.SetError(txtJoinPort, "Please provide a port number");
                errors++;
            }   
            if (errors > 0)
            {
                return;
            }
            Client ng = new Client(false, txtJoinName.Text, txtJoinIP.Text, Int32.Parse(txtJoinPort.Text));
            ng.Show();
            this.Hide();
        }

        private void IntOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
