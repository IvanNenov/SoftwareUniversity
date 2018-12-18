using _03BarracksFactory.Models.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarrackWars_ANewFactory.Models.Units
{
    public class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 100;

        public Horseman() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
