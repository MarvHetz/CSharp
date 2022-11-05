using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsAppReise
{
    internal class Verwaltung
    {
        private Reise reisen;
        public Verwaltung()
        {
            
        }
        
        internal Reise Reisen { get => reisen; set => reisen = value; }

        public List<Mensch> neuerTeilnehmer(Reise temp, string name, string email, string nachname)
        {
            temp.neuerTeilnehmer(name,email,nachname);
            return temp.Teilnehmer;
        }

        public List<Mensch> neueReiseLaden(Reise neueReise)
        {
            return neueReise.Teilnehmer;
        }

        public void auslesen()
        {
            try
            {
                StreamReader sr = new StreamReader("Teilnehmer.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Mensch));

                List<Mensch> menschen = (List<Mensch>)serializer.Deserialize(sr);
                
                sr.Close();
                
                reisen = new Reise(new DateTime(2023,1,1),20,320,new DateTime(2023,3,1),"Kuba");
                reisen.Teilnehmer = menschen;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception();
            }
        }
    }
}
