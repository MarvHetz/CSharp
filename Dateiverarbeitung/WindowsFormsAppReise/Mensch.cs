using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    internal class Mensch
    {
        private string name;
        private string email;
        private string nachname;
        public static int anzahl = 0;
        private int teilnehmernr;

        public int Teilnehmernr { get => teilnehmernr; set => teilnehmernr = value; }

        public Mensch(string name, string email, string nachname)
        {
            this.name = name;
            this.email = email;
            this.nachname = nachname;
            anzahl++;
            teilnehmernr = anzahl;
        }


        public override string ToString()
        {
            return name;
        }
    }
}
