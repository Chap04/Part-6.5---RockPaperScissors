using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5___RockPaperScissors
{
    public partial class frmRockPaperScissors : Form
    {
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }
        Random opponentChoice = new Random();
        int opponentChoiceStore;
        int playerChoiceStore;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (radRock.Checked == true)
            {
                playerChoiceStore = 1;
            }
            else if (radPaper.Checked == true)
            {
                playerChoiceStore = 2;
            }
            else if (radScissors.Checked == true)
            {
                playerChoiceStore = 3;
            }
            switch (playerChoiceStore)
            {
                case 1:
                    imgPlayer.Image = Properties.Resources.Rock;
                    break;
                case 2:
                    imgPlayer.Image = Properties.Resources.Paper;
                    break;
                case 3:
                    imgPlayer.Image = Properties.Resources.Scissors;
                    break;
            }
            opponentChoiceStore = opponentChoice.Next(1, 4);
            switch (opponentChoiceStore)
            {
                case 1:
                    imgOpponent.Image = Properties.Resources.Rock;
                    break;
                case 2:
                    imgOpponent.Image = Properties.Resources.Paper;
                    break;
                case 3:
                    imgOpponent.Image = Properties.Resources.Scissors;
                    break;
            }
            if (playerChoiceStore == 1)
            {
                if (opponentChoiceStore == 1)
                {
                    lblOutput.Text = ("Tie!");
                }
                else if (opponentChoiceStore == 2)
                {
                    lblOutput.Text = ("You Lose! :(");
                }
                else if (opponentChoiceStore == 3)
                {
                    lblOutput.Text = ("You Win! :)");
                }
            }
            else if (playerChoiceStore == 2)
            {

            }
        }
    }
}
