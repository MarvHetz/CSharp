using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    public class Teilnehmer
    {
        private string vorname;
        private string email;
        private string nachname;
        private static int anzahl = 0;
        private int teilnehmerNummer;

        public int TeilnehmerNummer { get => teilnehmerNummer; set => teilnehmerNummer = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Email { get => email; set => email = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public static int Anzahl { get => anzahl; set => anzahl = value; }

        public Teilnehmer()
        {
            
        }
        public Teilnehmer(string name, string email, string nachname)
        {
            this.vorname = name;
            this.email = email;
            this.nachname = nachname;
            anzahl++;
            teilnehmerNummer = anzahl;
        }
        
        public override string ToString()
        {
            return vorname;
        }
    }
}