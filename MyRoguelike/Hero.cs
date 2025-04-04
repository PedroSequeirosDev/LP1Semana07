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
    }



}