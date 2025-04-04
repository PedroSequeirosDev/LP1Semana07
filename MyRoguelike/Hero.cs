using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;


        public string Name { get; }

        public int XP
        {
            get => xp;
            set
            {
                if (value > xp)
                {
                    xp = value;
                }

            }
        }

        public int Level
        {
            get => 1 + XP / 1000;
        }

        public float Health
        {
            get => health;
            set
            {
                if (value > 0 && value < Maxhealth)
                {
                    health = value;
                }
                else if (health <= 0)
                {
                    health = 0;
                }
            }
        }



    }
}



