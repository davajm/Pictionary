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
    public partial class ChooseWord : UserControl
    {
        public event EventHandler NewWordChosen;
        public ChooseWord()
        {
            InitializeComponent();
        }

        private void Word_Click(object sender, EventArgs e)
        {
            NewWordChosen(sender, new EventArgs());
        }

        /// <summary>
        /// This function swaps the words on the buttons. 
        /// This is typically called before a new user is going to draw.
        /// </summary>
        /// <param name="word1">First word</param>
        /// <param name="word2">Second word</param>
        /// <param name="word3">Third word</param>
        public void SwitchWords(string firstWord, string secondWord, string thirdWord)
        {
            word1.Text = firstWord;
            word2.Text = secondWord;
            word3.Text = thirdWord;
        }
    }
}
