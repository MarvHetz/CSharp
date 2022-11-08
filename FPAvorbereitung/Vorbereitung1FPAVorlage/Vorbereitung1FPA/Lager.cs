using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Vorbereitung1FPA
{
    public class Lager
    {
        private int laufendeNummer;
        private List<Artikel> listArtikel;

        public List<Artikel> ListArtikel { get => listArtikel;  }

        public Lager()
        {

        }

        public void ArtikelLaden()
        {

        }

        public void ArtikelSpeichern()
        {

        }

        public void ArtikelAufnehmen(string bezeichnung, decimal preis)
        {

        }

        public void ArtikelLoeschen(Artikel artikel)
        {

        }
    }
}
