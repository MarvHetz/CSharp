using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HausTierManager
{
    internal class Tier
    {
        private string name;
        private double gewicht;
        private bool geimpft;

        public Tier(string name,double gewicht)
        { 
            this.Name = name;
            this.Gewicht = gewicht;
            this.geimpft = false;
        }

        public string Name { get => name; set => name = value; }
        public double Gewicht { get => gewicht; set => gewicht = value; }

        public virtual void Fuettern()
        {}

        public void Impfen()
        { 
            geimpft = true;
        }
    }
}
