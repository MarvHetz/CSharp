using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    public class Teilnehmer
    {
        private string name;
        private string email;
        private string nachname;
        private int teilnehmerNummer;

        public Teilnehmer()
        { 
        }

        public Teilnehmer(string name, string email, string nachname)
        {
            this.Name = name;
            this.Email = email;
            this.nachname = nachname;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Nachname { get => nachname; set => nachname= value; }
        public int TeilnehmerNummer { get => teilnehmerNummer; set => teilnehmerNummer = value; }

        public override string ToString()
        {
            return name;
        }
    }
}
