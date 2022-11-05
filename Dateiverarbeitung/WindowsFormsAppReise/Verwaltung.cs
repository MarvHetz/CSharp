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

        public List<Teilnehmer> neuerTeilnehmer(string name, string email, string nachname)
        {
            reisen.neuerTeilnehmer(name,email,nachname);
            return reisen.Teilnehmer;
        }

        public List<Teilnehmer> neueReiseLaden(Reise neueReise)
        {
            return neueReise.Teilnehmer;
        }

        public void auslesen()
        {
            //try
            //{
                StreamReader sr = new StreamReader("Teilnehmer.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Teilnehmer));

                List<Teilnehmer> teilnehmer = (List<Teilnehmer>)serializer.Deserialize(sr);
                
                sr.Close();
                
                reisen = new Reise(new DateTime(2023,1,1),20,320,new DateTime(2023,3,1),"Kuba");
                reisen.Teilnehmer = teilnehmer;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            // throw new Exception();
            //}
        }
    }
}
