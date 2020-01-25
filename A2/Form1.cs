using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    public partial class Form1 : Form
    {
        public Game game;
        private bool inputError = false;
        private bool inputErrorMultiRoll = false;
        private Image die1 = Image.FromFile("die1.gif");
        private Image die2 = Image.FromFile("die2.gif");
        private Image die3 = Image.FromFile("die3.gif");
        private Image die4 = Image.FromFile("die4.gif");
        private Image die5 = Image.FromFile("die5.gif");
        private Image die6 = Image.FromFile("die6.gif");
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            pbDie.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDie.Image = die6;
            refreshStats();
        }

        public void refreshStats()
        {
            rtbResults.Text = "";
            rtbResults.Text += "FACE | FREQUENCY | PERCENT | # GUESSED\n";
            newLine((int)game.dieOne.face, game.dieOne.freq, game.dieOne.perc, game.dieOne.numGuessed);
            newLine((int)game.dieTwo.face, game.dieTwo.freq, game.dieTwo.perc, game.dieTwo.numGuessed);
            newLine((int)game.dieThree.face, game.dieThree.freq, game.dieThree.perc, game.dieThree.numGuessed);
            newLine((int)game.dieFour.face, game.dieFour.freq, game.dieFour.perc, game.dieFour.numGuessed);
            newLine((int)game.dieFive.face, game.dieFive.freq, game.dieFive.perc, game.dieFive.numGuessed);
            newLine((int)game.dieSix.face, game.dieSix.freq, game.dieSix.perc, game.dieSix.numGuessed);
            lblNumPlayed.Text = game.gamesPlayed.ToString("N0");
            lblNumWon.Text = game.gamesWon.ToString("N0");
            lblNumLost.Text = game.gamesLost.ToString("N0");
            Refresh();
        }
        public void newLine(int one, int two, double three, int four)
        {
            rtbResults.Text += String.Format("{0,-5}| {1,-10}| {2,-8:P2}| {3}\n", one, two, three, four);
        }

        private void textChangedGuess(object sender, EventArgs e)
        {
            int temp; //useless for now; I don't need the number, just to try. I'm sure there's a better way.
            if(!Int32.TryParse(tbGuess.Text, out temp)){
                lblInputError.Visible = true;
                inputError = true;
            } else
            {
                switch (temp)
                {
                    case 7:
                    case 8:
                    case 9:
                        lblInputError.Visible = true;
                        inputError = true;
                        break;
                    default:
                        lblInputError.Visible = false;
                        inputError = false;
                        break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            game = new Game();
            rtbResults.Text = "";
            refreshStats();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if(tbGuess.Text != "" && !inputError)
            {
                int roll;
                Random tempRNG = new Random();
                int sleepTime = 10;
                for (int i = 0; i < 10; i++)
                {
                    if (i == 9)
                    {
                        roll = game.playRound(Int32.Parse(tbGuess.Text));
                    } else
                    {
                        roll = tempRNG.Next(1, 7);
                    }
                    switch (roll)
                    {
                        case 1:
                            pbDie.Image = die1;
                            Thread.Sleep(sleepTime);
                            break;
                        case 2:
                            pbDie.Image = die2;
                            Thread.Sleep(sleepTime);
                            break;
                        case 3:
                            pbDie.Image = die3;
                            Thread.Sleep(sleepTime);
                            break;
                        case 4:
                            pbDie.Image = die4;
                            Thread.Sleep(sleepTime);
                            break;
                        case 5:
                            pbDie.Image = die5;
                            Thread.Sleep(sleepTime);
                            break;
                        case 6:
                            pbDie.Image = die6;
                            Thread.Sleep(sleepTime);
                            break;
                        default:
                            break;
                    }
                    sleepTime += 10;
                    Refresh();
                }
                refreshStats();
            }
        }

        private void btnMultiRoll_Click(object sender, EventArgs e)
        {
            if(tbMultiRoll.Text != "" && !inputErrorMultiRoll && tbGuess.Text != "" && !inputError)
            {
                int rolls = Int32.Parse(tbMultiRoll.Text);
                int guess = Int32.Parse(tbGuess.Text);
                for (int i = 0; i < rolls; i++)
                {
                    game.playRound(guess);
                }
                refreshStats();
            }
        }

        private void tbMultiRoll_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (!Int32.TryParse(tbMultiRoll.Text, out temp))
            {
                lblMultiError.Visible = true;
                inputErrorMultiRoll = true;
            }
            else
            {
                lblMultiError.Visible = false;
                inputErrorMultiRoll = false;
            }
        }
    }
}
