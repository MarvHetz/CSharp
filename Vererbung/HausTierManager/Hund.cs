using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HausTierManager
{
    internal class Hund : Tier
    {
        private int hundeSteuerNummer;
        public Hund(string name ,double gewicht, int hundeSteuerNummer) : base(name,gewicht)
        { 
            this.hundeSteuerNummer = hundeSteuerNummer;
        }

        public override void Fuettern()
        {
            Gewicht *= 1.02;
        }
    }
}
