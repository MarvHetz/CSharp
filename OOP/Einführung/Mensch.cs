using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMensch
{
    class Mensch
    {
        private string vorname;
        private string nachname;
        private int alter;
        private string familienstand;

        public Mensch(string vorname, string nachname, int alter)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            this.familienstand = "ledig";
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname 
        {
            get { return nachname; }    //===> Leserichtung
            set { nachname = value; }   //===> Schreibrichtung
        }
        public int Alter { get => alter;}
        public string Familienstand { get => familienstand; set => familienstand = value; }

        public int Geburtstag()
        {
            alter++;
            return alter;
        }

        public void Heiraten(string nachname)
        { 
            this.nachname = nachname;
            familienstand = "verheiratet";
        }
    }
}
