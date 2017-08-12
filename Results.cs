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
            mainTitle.Text = "Round's over, the word was:";
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
                    }
                    lblScore.Text = score.ToString();
                    tlpScoreBoard.RowCount++;
                    tlpScoreBoard.Controls.Add(lblName, 0, tlpScoreBoard.RowCount - 1);
                    tlpScoreBoard.Controls.Add(lblScore, 1, tlpScoreBoard.RowCount - 1);
                }
            }
        }

        public void ShowGameResult()
        {
            // to do: implement.
        }
    }
}
