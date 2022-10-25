using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    internal class Mensch
    {
        private string name;
        private string email;
        private string nachname;

        public Mensch(string name, string email, string nachname)
        {
            this.Name = name;
            this.Email = email;
            this.nachname = nachname;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Nachname { get => nachname; set => nachname= value; }

        public override string ToString()
        {
            return name;
        }
    }
}
