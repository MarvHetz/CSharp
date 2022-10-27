using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSerialisierung
{
    public class Mensch
    {
        private string vorname;
        private DateTime geburtsdatum;
        private string nachname;

        public Mensch()
        { 
        }

        public Mensch(string vorname, DateTime geburtsdatum, string nachname)
        {
            Vorname = vorname;
            Geburtsdatum = geburtsdatum;
            Nachname = nachname;
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public DateTime Geburtsdatum { get => geburtsdatum; set => geburtsdatum = value; }
        public string Nachname { get => nachname; set => nachname = value; }

        public override string ToString()
        {
            return Vorname;
        }
    }
}
