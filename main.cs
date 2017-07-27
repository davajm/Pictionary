﻿using System;
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
        public main()
        {
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
            Client ng = new Client(true, txtHostName.Text);
            ng.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Client ng = new Client(false, txtJoinName.Text);
            ng.Show();
        }
    }
}