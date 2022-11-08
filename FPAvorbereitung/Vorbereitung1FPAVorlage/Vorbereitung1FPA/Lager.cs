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
        public int Anzahl { get => listArtikel.Count; }

        public Lager()
        {

        }

        public void ArtikelLaden()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Artikel>));
                TextReader tr = new StreamReader("Artikel.xml");
                listArtikel = (List<Artikel>)serializer.Deserialize(tr);
                tr.Close();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            laufendeNummer = ((Artikel)listArtikel.LastOrDefault<Artikel>()).Nummer + 1;
        }

        public void ArtikelSpeichern()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Artikel>));
                TextWriter tw = new StreamWriter("Artikel.xml");
                serializer.Serialize(tw, listArtikel);
                tw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ArtikelAufnehmen(string bezeichnung, decimal preis)
        {
            laufendeNummer = ((Artikel)ListArtikel.LastOrDefault<Artikel>()).Nummer + 1;
            listArtikel.Add(new Artikel(laufendeNummer,bezeichnung,preis));
            
        }

        public void ArtikelLoeschen(Artikel artikel)
        {
                listArtikel.Remove(artikel);
        }
    }
}
