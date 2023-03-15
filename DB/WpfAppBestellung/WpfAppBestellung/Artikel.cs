using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBestellung
{
    public class Artikel
    {
        private string artikelNummer;
        private int artikelOid;
        private int bestand;
        private string bezeichnung;
        private int meldebestand;
        private decimal vkPreis;

        public Artikel(string artikelNummer, int artikelOid, int bestand, string bezeichnung, int meldebestand, decimal vkPreis)
        {
            this.artikelNummer = artikelNummer;
            this.artikelOid = artikelOid;
            this.bestand = bestand;
            this.bezeichnung = bezeichnung;
            this.meldebestand = meldebestand;
            this.vkPreis = vkPreis;
        }

        public string ArtikelNummer { get => artikelNummer; set => artikelNummer = value; }
        public int ArtikelOid { get => artikelOid; set => artikelOid = value; }
        public int Bestand { get => bestand; set => bestand = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public int Meldebestand { get => meldebestand; set => meldebestand = value; }
        public decimal VkPreis { get => vkPreis; set => vkPreis = value; }
    }
}
