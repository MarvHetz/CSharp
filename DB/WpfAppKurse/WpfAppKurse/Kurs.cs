using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKurse
{
    public class Kurs
    {
        private string bezeichnung;
        private DateTime datum;
        private int iD;
        private List<Teilnehmer> teilnehmer;

        public Kurs(string bezeichnung, DateTime datum, int iD)
        {
            this.bezeichnung = bezeichnung;
            this.datum = datum;
            this.iD = iD;
            this.teilnehmer = new List<Teilnehmer>();
        }

        public Kurs()
        { }

        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int ID { get => iD; set => iD = value; }
        public List<Teilnehmer> Teilnehmer { get => teilnehmer; set => teilnehmer = value; }

        public override string ToString()
        {
            return bezeichnung;
        }
    }
}
