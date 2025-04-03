using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;

        private int playedGames;

        private int wonGames;

        private float ValueofRun;





        public float HighScore
        {
            get => highScore;
            set
            {
                if (ValueofRun > highScore)
                {
                    highScore = value;
                }
            }
        }

        public string Name { get; }

        public float WinRate
        {
            get
            {
                if (playedGames > 0)
                {
                    return (float)wonGames / playedGames;
                }

                else
                {
                    return 0;
                }


            }


        }


    }
}