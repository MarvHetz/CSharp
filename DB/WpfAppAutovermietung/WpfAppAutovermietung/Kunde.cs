using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAutovermietung
{
    public class Kunde
    {
        private int id;
        private string name;
        private string vorname;
        private string strasse;
        private string ort;
        private string telefon;
        private string ausweisnummer;
        private int plz;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Ausweisnummer { get => ausweisnummer; set => ausweisnummer = value; }
        public int Plz { get => plz; set => plz = value; }

        public override string ToString()
        {
            return vorname + " " + name;
        }
    }
}
