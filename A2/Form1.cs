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
    /// <summary>
    /// The overall game form, responsible for the window for Dice Roll/Guessing
    /// </summary>
    public partial class Form1 : Form
    {
        #region Attributes
        /// <summary>
        /// The current Game object responsible for storing stats, dice rolls, and rolling the die.
        /// </summary>
        public Game game;
        /// <summary>
        /// Boolean responsible for determining if the player guess textbox is currently an allowed integer (1-6).
        /// </summary>
        private bool inputError = false;
        /// <summary>
        /// Boolean responsible for determining if the players multiRoll number is currently an allowed integer (0-9999999).
        /// </summary>
        private bool inputErrorMultiRoll = false;
        /// <summary>
        /// The boolean responsible for determining if the image files are located next to the exe.
        /// </summary>
        private bool hasImages = true;
        /// <summary>
        /// The first die image for rolling a 1.
        /// </summary>
        private Image die1;
        /// <summary>
        /// The second die image for rolling a 2.
        /// </summary>
        private Image die2;
        /// <summary>
        /// The third die image for rolling a 3.
        /// </summary>
        private Image die3;
        /// <summary>
        /// The fourth die image for rolling a 4.
        /// </summary>
        private Image die4;
        /// <summary>
        /// The fifth die image for rolling a 5.
        /// </summary>
        private Image die5;
        /// <summary>
        /// The sixth die image for rolling a 6.
        /// </summary>
        private Image die6;
        #endregion
        #region Constructor
        /// <summary>
        /// The constructor that initializes the window, game object, and images.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Constructing a new game.
            game = new Game();
            //If the images are not right next to the exe this is to prevent the whole thing from crashing.
            try
            {
                die1 = Image.FromFile("die1.gif");
                die2 = Image.FromFile("die2.gif");
                die3 = Image.FromFile("die3.gif");
                die4 = Image.FromFile("die4.gif");
                die5 = Image.FromFile("die5.gif");
                die6 = Image.FromFile("die6.gif");
                pbDie.SizeMode = PictureBoxSizeMode.StretchImage;
                pbDie.Image = die6;
            }
            catch (Exception)
            {
                //Oops, no images.
                hasImages = false;
                //Well... At least the program doesn't just die. ¯\_(ツ)_/¯
            }
            refreshStats();
        }
        #endregion
        #region Methods
        /// <summary>
        /// The method responsible for refreshing the rich text box with the results. Gets called after ever roll.
        /// Refreshes the labels for games played, won, and lost as well.
        /// </summary>
        public void refreshStats()
        {
            rtbResults.Text = ""; //wiping the textbox
            rtbResults.Text += "FACE | FREQUENCY | PERCENT | # GUESSED\n"; //formatting the headers
            //calls newLine with 3 ints and 1 double that are placed with proper spacing and formatting.
            newLine((int)game.dieOne.face, game.dieOne.freq, game.dieOne.perc, game.dieOne.numGuessed);
            newLine((int)game.dieTwo.face, game.dieTwo.freq, game.dieTwo.perc, game.dieTwo.numGuessed);
            newLine((int)game.dieThree.face, game.dieThree.freq, game.dieThree.perc, game.dieThree.numGuessed);
            newLine((int)game.dieFour.face, game.dieFour.freq, game.dieFour.perc, game.dieFour.numGuessed);
            newLine((int)game.dieFive.face, game.dieFive.freq, game.dieFive.perc, game.dieFive.numGuessed);
            newLine((int)game.dieSix.face, game.dieSix.freq, game.dieSix.perc, game.dieSix.numGuessed);
            //Updating the stats in the groupBox
            lblNumPlayed.Text = game.gamesPlayed.ToString("N0");
            lblNumWon.Text = game.gamesWon.ToString("N0");
            lblNumLost.Text = game.gamesLost.ToString("N0");
            //Refreshing the whole window to update the stats.
            Refresh();
        }
        /// <summary>
        /// The method responsible for printing a new line in the rich text box that is formatted correctly.
        /// </summary>
        /// <param name="one">The current face of the die</param>
        /// <param name="two">The number of times that face has been rolled, frequency.</param>
        /// <param name="three">The percentage of time that roll has appeared, pass in the form of a double, IE 0.15 = 15% </param>
        /// <param name="four">The number of times that number has been guessed</param>
        public void newLine(int one, int two, double three, int four)
        {
            rtbResults.Text += String.Format("{0,-5}| {1,-10}| {2,-8:P2}| {3}\n", one, two, three, four);
        }
        /// <summary>
        /// The event responsible for checking if the player's guess is an allowed integer (1-6).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textChangedGuess(object sender, EventArgs e)
        {
            int temp; //The current number in the guess box. Actually not so useless now. 
            if (!Int32.TryParse(tbGuess.Text, out temp)){
                lblInputError.Visible = true;
                inputError = true;
            } else
            {
                switch (temp)
                {
                    case 0:
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
        /// <summary>
        /// The event responsible for resetting the game object and clearing the stats. Updates the stats after being called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            game = new Game();
            rtbResults.Text = "";
            refreshStats();
        }
        /// <summary>
        /// The event responsible for rolling the die after being clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //If the current guess is a number and not a space or error
            if(tbGuess.Text != "" && !inputError)
            {
                int roll; //temporary roll to decide what die face to place
                Random tempRNG = new Random(); //Random number generator used to roll the faces.
                int sleepTime = 10; //Time to sleep between rolls, goes up over 10 rolls.
                for (int i = 0; i < 10; i++)
                {
                    //If on the last roll
                    if (i == 9)
                    {
                        //roll a real number and not a fake one
                        roll = game.playRound(Int32.Parse(tbGuess.Text));
                    } else
                    {
                        //roll a fake number
                        roll = tempRNG.Next(1, 7);
                    }
                    //If the program did not error out earlier on trying to load pictures.
                    // Funnily enough, with no images the rolling is significantly faster!
                    if (hasImages)
                    {
                        //Changes the image and sleeps.
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
                        //adds an extra 10 ms to the roll sleep duration every roll, slowing the die speed down over time.
                        sleepTime += 10;
                        Refresh();
                    }
                }
                //And after that lovely show, refresh the stats to display the number that was just rolled.
                refreshStats();
            }
        }
        /// <summary>
        /// Extra method used to roll multiple time. Does not display any visuals, just rolls. Purely for getting data in the table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiRoll_Click(object sender, EventArgs e)
        {
            //If the multiroll amount is a real number...
            if(tbMultiRoll.Text != "" && !inputErrorMultiRoll)
            {
                int rolls = Int32.Parse(tbMultiRoll.Text);
                for (int i = 0; i < rolls; i++)
                {
                    game.playRound(7); //sends a roll of 7 to not add any guess to the table.
                }
                refreshStats();
            }
        }
        /// <summary>
        /// Method responsible for checking if the current entered Multiroll is a valid number (0-9,999,999)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion
    }
}
