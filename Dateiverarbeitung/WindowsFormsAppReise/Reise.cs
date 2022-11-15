using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    public class Reise
    {
        private List<Teilnehmer> lstTeilnehmer;
        private int anzahlTeilnehmer;
        private DateTime bis;
        private int maxTeilnehmer;
        private decimal preis;
        private DateTime von;
        private string ziel;

        
        public int AnzahlTeilnehmer { get => anzahlTeilnehmer; set => anzahlTeilnehmer = value; }
        public DateTime Bis { get => bis; set => bis = value; }
        public int MaxTeilnehmer { get => maxTeilnehmer; set => maxTeilnehmer = value; }
        public decimal Preis { get => preis; set => preis = value; }
        public DateTime Von { get => von; set => von = value; }
        public string Ziel { get => ziel; set => ziel = value; }
        public List<Teilnehmer> LstTeilnehmer { get => lstTeilnehmer; set => lstTeilnehmer = value; }

        public Reise()
        {
        }

        public Reise(DateTime bis, int maxTeilnehmer, decimal preis, DateTime von, string ziel)
        {
            this.lstTeilnehmer = new List<Teilnehmer>();
            this.anzahlTeilnehmer = 0;
            this.bis = bis;
            this.maxTeilnehmer = maxTeilnehmer;
            this.preis = preis;
            this.von = von;
            this.ziel = ziel;
        }

        public void neuerTeilnehmer(string name, string email, string nachname)
        {
            lstTeilnehmer.Add(new Teilnehmer(name, email, nachname));
        }

        public override string ToString()
        {
            return ziel;
        }
    }
}
