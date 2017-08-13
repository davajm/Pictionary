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
            this.isDrawing = false;
            InitializeComponent();
            lblName.Text = name;
            lblScore.Text = "0";
        }
        public int GetTotalScore()
        {
            return totalScore;
        }

        public int GetRoundScore()
        {
            return currentScore;
        }
        public void NewGame()
        {
            totalScore = currentScore = 0;
            lblScore.Text = "0";
            ready = lblState.Enabled = lblState.Visible = false;
        }

        public string GetName()
        {
            return name;
        }

        public void EndRound()
        {
            totalScore += currentScore;
            currentScore = 0;
            isDrawing = lblState.Enabled = lblState.Visible = false;
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

        public void SetDrawing()
        {
            lblState.Text = "Drawing";
            this.isDrawing = lblState.Enabled = lblState.Visible = true;
        }
        public bool IsDrawing()
        {
            return isDrawing;
        }

        public void SetChoosingWord()
        {
            lblState.Text = "Choosing word";
            lblState.Enabled = lblState.Visible = true;
        }

        public void Ready()
        {
            ready = !ready;
            lblState.Text = "Ready";
            lblState.Enabled = lblState.Visible = ready;
        }
    }
}
