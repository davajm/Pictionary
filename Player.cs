using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictionary
{
    public partial class Player : UserControl
    {
        private string name;
        private int score;
        private bool ready;

        public Player(string name)
        {
            ready = false;
            this.name = name;
            InitializeComponent();
            lblName.Text = name;
        }

        public string GetName()
        {
            return name;
        }

        public void AddScore(int score)
        {
            this.score += score;
            lblScore.Text = this.score.ToString();
        }

        public void ResetScore()
        {
            score = 0;
            lblScore.Text = score.ToString();
        }

        public void SetDrawing(bool isDrawing)
        {
            lblState.Text = "Drawing";
            lblState.Enabled = lblState.Visible = isDrawing;
        }

        public void Ready()
        {
            ready = !ready;
            lblState.Text = "Ready";
            lblState.Enabled = lblState.Visible = ready;
        }
    }
}
