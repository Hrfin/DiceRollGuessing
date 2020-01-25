using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    /// <summary>
    /// The overall Game class, holds all information relating to the current game. Reset remakes a game class.
    /// </summary>
    public class Game
    {
        #region Attributes
        /// <summary>
        /// The total number of games played. Only gettable, use playRound() to increment.
        /// </summary>
        public int gamesPlayed { get; set; }
        /// <summary>
        /// The total number of games Won. Only gettable, use playRound() to increment. 
        /// </summary>
        public int gamesWon { get; set; }
        /// <summary>
        /// The total number of games Lost. Only gettable, use playRound() to increment.
        /// </summary>
        public int gamesLost { get; set; }
        /// <summary>
        /// The Random number generator used by the Game class to pick rolls. Independent of the visual roll.
        /// </summary>
        public Random random;
        /// <summary>
        /// The stats for all of the number 1; Face, Frequency, Percent, and Number of times guessed.
        /// </summary>
        public Die dieOne { get; set; }
        /// <summary>
        /// The stats for all of the number 2; Face, Frequency, Percent, and Number of times guessed.
        /// </summary>
        public Die dieTwo { get; set; }
        /// <summary>
        /// The stats for all of the number 3; Face, Frequency, Percent, and Number of times guessed.
        /// </summary>
        public Die dieThree { get; set; }
        /// <summary>
        /// The stats for all of the number 4; Face, Frequency, Percent, and Number of times guessed.
        /// </summary>
        public Die dieFour { get; set; }
        /// <summary>
        /// The stats for all of the number 5; Face, Frequency, Percent, and Number of times guessed.
        /// </summary>
        public Die dieFive { get; set; }
        /// <summary>
        /// The stats for all of the number 6; Face, Frequency, Percent, and Number of times guessed.
        /// </summary>
        public Die dieSix { get; set; }
        #endregion
        #region Constructor
        /// <summary>
        /// Constructs a new Game object, setting everything to zero and making new dice with new stats.
        /// </summary>
        public Game()
        {
            //All new, baby
            gamesPlayed = gamesWon = gamesLost = 0;
            random = new Random();
            dieOne = new Die(Die.Face.one);
            dieTwo = new Die(Die.Face.two);
            dieThree = new Die(Die.Face.three);
            dieFour = new Die(Die.Face.four);
            dieFive = new Die(Die.Face.five);
            dieSix = new Die(Die.Face.six);
            
        }
        #endregion
        #region Methods
        public int playRound(int guess)
        {
            //temp variable to hold the roll.
            int roll = random.Next(1, 7);
            //always increments game played, regardless of guessed or not.
            gamesPlayed++;
            //checking to see if the passed guess was the same as the roll and incrementing stats depending.
            if (roll == guess)
            {
                gamesWon++;
            } else
            {
                gamesLost++;
            }
            //incrementing the frequency and percent based on what was rolled. Found that no matter how I did I'd
            // end up using two switch statements, so I pulled them out of the if statement above.
            switch (roll)
            {
                case 1:
                    dieOne.freq++;
                    refreshPercentages();
                    break;
                case 2:
                    dieTwo.freq++;
                    refreshPercentages();
                    break;
                case 3:
                    dieThree.freq++;
                    refreshPercentages();
                    break;
                case 4:
                    dieFour.freq++;
                    refreshPercentages();
                    break;
                case 5:
                    dieFive.freq++;
                    refreshPercentages();
                    break;
                case 6:
                    dieSix.freq++;
                    refreshPercentages();
                    break;
                default:
                    throw new Exception("Incorrect random number from playRound roll, expected 1-6, got " + roll);
            }
            //Incrementing the guess based on the guess.
            switch (guess)
            {
                case 1:
                    dieOne.numGuessed++;
                    break;
                case 2:
                    dieTwo.numGuessed++;
                    break;
                case 3:
                    dieThree.numGuessed++;
                    break;
                case 4:
                    dieFour.numGuessed++;
                    break;
                case 5:
                    dieFive.numGuessed++;
                    break;
                case 6:
                    dieSix.numGuessed++;
                    break;
                default:
                    break;
            }
            return roll;
        }
        /// <summary>
        /// Method used for refreshing all of the die percentages each roll.
        /// </summary>
        private void refreshPercentages()
        {
            dieOne.perc = ((double)dieOne.freq / (double)gamesPlayed);
            dieTwo.perc = ((double)dieTwo.freq / (double)gamesPlayed);
            dieThree.perc = ((double)dieThree.freq / (double)gamesPlayed);
            dieFour.perc = ((double)dieFour.freq / (double)gamesPlayed);
            dieFive.perc = ((double)dieFive.freq / (double)gamesPlayed);
            dieSix.perc = ((double)dieSix.freq / (double)gamesPlayed);
        }
        /// <summary>
        /// class used exclusively within game to hold the stats and information of each die face. Is accessed to print each row of the table.
        /// </summary>
        public class Die
        {
            /// <summary>
            /// Public enumeration of all the possible die faces. Used to construct new die and reference their face.
            /// </summary>
            public enum Face
            {
                one = 1,
                two = 2,
                three = 3,
                four = 4,
                five = 5,
                six = 6
            }
            /// <summary>
            /// The current Die's face, must be set with the Enumeration Face rather than integer.
            /// </summary>
            public Face face { get; set; }
            /// <summary>
            /// The frequency the current die has been thrown.
            /// </summary>
            public int freq { get; set; }
            /// <summary>
            /// The percentage that the die has been thrown. freq / gamesPlayed
            /// </summary>
            public double perc { get; set; }
            /// <summary>
            /// The number of times the die has been guessed as opposed to thrown.
            /// </summary>
            public int numGuessed { get; set; }
            /// <summary>
            /// Constructs a new die with all new stats, requires a face from the enumeration Face in Die.Face to be used.
            /// </summary>
            /// <param name="face">The current face of the die from enum Face</param>
            public Die(Face face)
            {
                this.face = face;
                freq = 0;
                perc = 0.0;
                numGuessed = 0;
            }

        }
        #endregion
    }
}
