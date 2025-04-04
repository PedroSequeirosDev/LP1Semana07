using System;
using System.Collections.Generic;
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

    }



}