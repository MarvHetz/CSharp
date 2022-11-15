using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsAppReise
{
    internal class Verwaltung
    {
        private List<Reise> reisen;

        public List<Reise> Reisen { get => reisen; set => reisen = value; }

        public Verwaltung()
        {
            Reisen = new List<Reise>();
        }

        public Reise neuerTeilnehmer(Reise temp, string name, string email, string nachname)
        {
            temp.neuerTeilnehmer(name,email,nachname);
            return temp;
        }

        public List<Teilnehmer> neueReiseLaden(Reise neueReise)
        {
            return neueReise.LstTeilnehmer;
        }

        public void alleReisenLaden()
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Reise>));
            TextReader reader = new StreamReader("Reisen.xml");
            reisen = (List<Reise>) serializer.Deserialize(reader);
            reader.Close();

        }

        public Reise teilnehmerLoeschen(Reise reise,Teilnehmer zuLoeschen)
        { 
            reise.LstTeilnehmer.Remove(zuLoeschen);
            return reise;
        }

        public void neueReise(DateTime bis,int maxTeilnehmer,decimal preis,DateTime von, string ziel)
        { 
            reisen.Add(new Reise(bis,maxTeilnehmer,preis,von,ziel));
        }

        public void reiseLoeschen(Reise zuLoeschen)
        {
            reisen.Remove(zuLoeschen);
        }
    }
}
