using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    public class Reise
    {
        private List<Mensch> teilnehmer;

        private int anzahlTeilnehmer;
        private DateTime bis;
        private int maxTeilnehmer;
        private decimal preis;
        private DateTime von;
        private string ziel
        internal List<Mensch> Teilnehmer { get => teilnehmer; set => teilnehmer = value; }

        public void neuerTeilnehmer(string name, string email, string nachname)
        {
            teilnehmer.Add(new Mensch(name, email, nachname));
        }
    }
}
