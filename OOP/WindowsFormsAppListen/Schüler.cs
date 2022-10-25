using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppListen
{
    internal class Schüler
    {
        private string name;
        private DateTime geb;
        private string wohnort;

        public Schüler(string name, DateTime geb, string wohnort)
        {
            this.Name = name;
            this.Geb = geb;
            this.Wohnort = wohnort;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Geb { get => geb; set => geb = value; }
        public string Wohnort { get => wohnort; set => wohnort = value; }

        public override string ToString()
        {
            return name;
        }
    }
}
