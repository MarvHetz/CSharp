using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    internal class Verwaltung
    {
        private List<Reise> reisen;
        public Verwaltung()
        {
            reisen = new List<Reise>();
        }
        
        internal List<Reise> Reisen { get => reisen; set => reisen = value; }

        public List<Mensch> neuerTeilnehmer(Reise temp, string name, string email, string nachname)
        {
            temp.neuerTeilnehmer(name,email,nachname);
            return temp.Teilnehmer;
        }

        public List<Mensch> neueReiseLaden(Reise neueReise)
        {
            return neueReise.Teilnehmer;
        }
    }
}
