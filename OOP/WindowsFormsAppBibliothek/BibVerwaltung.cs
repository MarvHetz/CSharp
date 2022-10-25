using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBibliothek
{
    public class BibVerwaltung
    {
        private Buch[] bücherliste;

        internal Buch[] Bücherliste { get => bücherliste; set => bücherliste = value; }

        public BibVerwaltung()
        {
            bücherliste = new Buch[5];

            bücherliste[0] = new Buch("Die Sus der Erde", "Ken Follet");
            bücherliste[1] = new Buch("Harry Poter", "J. K. Rowling");
            bücherliste[2] = new Buch("Der Herr der Ringe", "Amazon Prime");
            bücherliste[3] = new Buch("Die Stad der träumenden Büche-r", "Walter Moers");
            bücherliste[4] = new Buch("Pippi Langstrumpf", "Astrid Ligren");


        }
    }
}
