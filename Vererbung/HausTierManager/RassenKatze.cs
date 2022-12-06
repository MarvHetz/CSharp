using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HausTierManager
{
    internal class RassenKatze : Katze
    {
        public RassenKatze(string name, double gewicht) : base(name, gewicht)
        {
            Geimpft = 0;
        }

        public override void Impfen()
        {
            if (Geimpft < 3)
                Geimpft++;
            else 
                throw new Exception("Rassenkatzen können nur 3 Mal geimpft werden"); 
        }

        public override void Fuettern()
        {
            Gewicht *= 1.03;
        }

        public override void VerlaufErweitern()
        {
            Verlauf.Add("Rassenkatze " + Name + " " + Gewicht + " " + Geimpft);
        }
    }
}
