using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorbereitung1FPA
{
    public class Artikel
    {
        private int nummer;
        private string bezeichung;
        private decimal preis;
        public Artikel ()
        { }
        public Artikel(int nummer, string bezeichung, decimal preis)
        {
            this.Nummer = nummer;
            this.Bezeichung = bezeichung;
            this.Preis = preis;
        }

        public int Nummer { get => nummer; set => nummer = value; }
        public string Bezeichung { get => bezeichung; set => bezeichung = value; }
        public decimal Preis { get => preis; set => preis = value; }


    }
}
