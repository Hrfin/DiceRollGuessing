namespace A2
{
    public partial class Game
    {
        /// <summary>
        /// class used exclusively within Game to hold the stats and information of each die face. Is accessed to print each row of the table.
        /// </summary>
        public class Die
        {
            #region Attributes
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
            #endregion
            #region Constructor
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
