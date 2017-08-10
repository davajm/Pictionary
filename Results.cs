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
        public Results(List<Player> players)
        {
            this.players = players;
            InitializeComponent();
        }
        public void ShowRoundScore()
        {
            foreach (Player player in players)
            {
                if (!player.isDrawing())
                {
                    // Add player to list
                }
            }
        }
        public void ShowGameResult()
        {

        }
    }
}
