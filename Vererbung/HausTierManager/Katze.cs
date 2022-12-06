using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HausTierManager
{
    internal class Katze : Tier
    {
        public Katze(string name, double gewicht) : base(name,gewicht)
        {
            
        }

        public override void Fuettern()
        {
            Gewicht *= 1.02;
        }

        public override void Impfen()
        {
            Geimpft++;
        }

        public override void VerlaufErweitern()
        {
            Verlauf.Add("Katze "+Name+" "+Gewicht+" "+Geimpft);
        }
    }
}
