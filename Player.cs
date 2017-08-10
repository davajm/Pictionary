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
        private int totalScore, currentScore;
        private bool ready;
        private bool isDrawing;

        public Player(string name)
        {
            ready = false;
            this.name = name;
            InitializeComponent();
            lblName.Text = name;
            lblScore.Text = "0";
        }
        public int GetRoudScore()
        {
            return currentScore;
        }

        public string GetName()
        {
            return name;
        }

        public void AddScore(int score)
        {
            currentScore = score;
            lblScore.Text = currentScore.ToString();
            lblState.Text = "+" + currentScore;
            lblState.Enabled = lblState.Visible = true;
        }

        public void ResetScore()
        {
            totalScore = 0;
            currentScore = 0;
            lblScore.Text = totalScore.ToString();
        }

        public void SetDrawing(bool isDrawing)
        {
            lblState.Text = "Drawing";
            isDrawing = lblState.Enabled = lblState.Visible = isDrawing;
        }
        public bool IsDrawing()
        {
            return isDrawing;
        }

        public void SetChoosingWord(bool isChoosing)
        {
            lblState.Text = "Choosing word";
            totalScore += currentScore;
            currentScore = 0;
            lblState.Enabled = lblState.Visible = isChoosing;
        }

        public void Ready()
        {
            ready = !ready;
            lblState.Text = "Ready";
            lblState.Enabled = lblState.Visible = ready;
        }
    }
}
