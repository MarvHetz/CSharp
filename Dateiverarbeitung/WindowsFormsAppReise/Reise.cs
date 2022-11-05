using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    public class Reise
    {
        private List<Mensch> teilnehmer;

        private int anzahlTeilnehmer = 0;
        private DateTime bis;
        private int maxTeilnehmer;
        private decimal preis;
        private DateTime von;
        private string ziel;

        public Reise(DateTime bis, int maxTeilnehmer, decimal preis, DateTime von, string ziel)
        {
            this.bis = bis;
            this.maxTeilnehmer = maxTeilnehmer;
            this.preis = preis;
            this.von = von;
            this.ziel = ziel;
            teilnehmer = new List<Mensch>();
        }

        internal List<Mensch> Teilnehmer { get => teilnehmer; set => teilnehmer = value; }

        public void neuerTeilnehmer(string name, string email, string nachname)
        {
            teilnehmer.Add(new Mensch(name, email, nachname));
            anzahlTeilnehmer++;
        }

        public void TeilnehmerLöschen(Mensch zuLöschen)
        { 
            teilnehmer.Remove(zuLöschen);
        }

        public override string ToString()
        {
            return ziel;
        }
    }
}
