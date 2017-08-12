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
    public partial class Results : UserControl
    {
        List<Player> players;
        string word;
        public Results(List<Player> players)
        {
            this.players = players.OrderByDescending(o => o.GetTotalScore()).ToList();
            InitializeComponent();
            ShowGameResult();
        }
        public Results(List<Player> players, string word)
        {
            this.players = players.OrderByDescending(o => o.GetRoundScore()).ToList();
            this.word = word;
            InitializeComponent();
            ShowRoundResult();
        }

        public void ShowRoundResult()
        {
            mainTitle.Text = "Round is over, the word was:";
            subTitle.Text = word.ToUpper();
            subTitle.ForeColor = Color.Red;
            foreach (Player player in players)
            {
                if (!player.IsDrawing())
                {
                    Label lblName = new Label();
                    Label lblScore = new Label();
                    lblName.Text = player.GetName();
                    int score = player.GetRoundScore();
                    if (score > 0)
                    {
                        lblScore.ForeColor = Color.Green;
                        lblScore.Text = "+";
                    }
                    lblScore.Text += score.ToString();
                    tlpScoreBoard.RowCount++;
                    tlpScoreBoard.Controls.Add(lblName, 0, tlpScoreBoard.RowCount - 1);
                    tlpScoreBoard.Controls.Add(lblScore, 1, tlpScoreBoard.RowCount - 1);
                }
            }
        }

        public void ShowGameResult()
        {
            /* Check if there are multiple winners (if we have a draw) */
            List<string> winners = new List<string>();
            winners.Add(players[0].GetName());

            // Get names of players with highest score
            for (int i = 1; i < players.Count; i++)
            {
                if (players[i].GetTotalScore() == players[0].GetTotalScore())
                {
                    winners.Add(players[i].GetName());
                }
                else
                {
                    break;
                }
            }
            if (winners.Count > 1) // If multiple winners
            {
                mainTitle.Text = "Game is over, the winners are:";
                subTitle.Text = "";
                foreach (string winner in winners)
                {
                    subTitle.Text += winner + " ";
                }
                subTitle.ForeColor = Color.Green;

            }
            else // If one winner
            {
                mainTitle.Text = "Game is over, the winner is:";
                subTitle.Text = winners[0].ToUpper();
                subTitle.ForeColor = Color.Green;
            }

            foreach (Player player in players)
            {
                Label lblName = new Label();
                Label lblScore = new Label();
                lblName.Text = player.GetName();
                lblScore.ForeColor = Color.Green;
                lblScore.Text = player.GetTotalScore().ToString();
                tlpScoreBoard.RowCount++;
                tlpScoreBoard.Controls.Add(lblName, 0, tlpScoreBoard.RowCount - 1);
                tlpScoreBoard.Controls.Add(lblScore, 1, tlpScoreBoard.RowCount - 1);
            }

        }
    }
}
