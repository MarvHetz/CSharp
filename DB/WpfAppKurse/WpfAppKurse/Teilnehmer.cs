using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKurse
{
    public class Teilnehmer
    {
        private string email;
        private int iD;
        private string nachname;
        private string vorname;

        public Teilnehmer(string email, int iD, string nachname, string vorname)
        {
            this.email = email;
            this.iD = iD;
            this.nachname = nachname;
            this.vorname = vorname;
        }

        public Teilnehmer()
        { }

        public string Email { get => email; set => email = value; }
        public int ID { get => iD; set => iD = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }

        public override string ToString()
        {
            return vorname + " " + nachname;
        }
    }
}
