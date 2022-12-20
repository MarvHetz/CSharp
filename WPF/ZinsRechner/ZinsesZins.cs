using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinsRechner
{
    public class ZinsesZins
    {
        private double kapital;
        private double zinssatz;
        private double laufzeit;
        private double endKapital;

        public ZinsesZins()
        { }

        public double Kapital { get => kapital; set => kapital = value; }
        public double Zinssatz { get => zinssatz; set => zinssatz = value; }
        public double Laufzeit { get => laufzeit; set => laufzeit = value; }
        public double EndKapital { get => endKapital; set => endKapital = value; }
    }
}
