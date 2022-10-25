using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSerialisierung
{
    internal class Mensch
    {
        private string name;
        private DateTime geb;
        private string nachname;

        public Mensch(string name, DateTime geb, string nachname)
        {
            this.Name = name;
            this.Geb = geb;
            this.nachname = nachname;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Geb { get => geb; set => geb = value; }
        public string Nachname { get => nachname; set => nachname= value; }

        public override string ToString()
        {
            return name;
        }
    }
}
