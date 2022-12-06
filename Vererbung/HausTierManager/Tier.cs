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
        private int geimpft;
        List<string> verlauf;

        public Tier(string name,double gewicht)
        { 
            this.Name = name;
            this.Gewicht = gewicht;
            this.Geimpft = 0;
            Verlauf = new List<string>();
        }

        public string Name { get => name; set => name = value; }
        public double Gewicht { get => gewicht; set => gewicht = value; }
        public int Geimpft { get => geimpft; set => geimpft = value; }
        public List<string> Verlauf { get => verlauf; set => verlauf = value; }

        public virtual void Fuettern()
        {}

        public virtual void Impfen()
        {
            Geimpft++;
        }

        public override string ToString()
        {
            return name;
        }

        public virtual void VerlaufErweitern()
        {
        }
    }
}
