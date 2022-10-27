using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsAppSerialisierung
{
    internal class Verwaltung
    {
        private List<Mensch> menschen;

        public Verwaltung()
        { 
            menschen = new List<Mensch>();
        }

        public List<Mensch> lesen() 
        {
            //try
            //{
                /*StreamReader sr = new StreamReader("Menschen.csv",Encoding.UTF8);
                string einlesen;

                while (sr.EndOfStream == false)
                { 
                    einlesen = sr.ReadLine();
                    string name = einlesen.Split(';')[0];
                    string nachname = einlesen.Split(';')[1];
                    DateTime geb = Convert.ToDateTime(einlesen.Split(';')[2]);

                    Mensch temp = new Mensch(name, geb, nachname);
                    menschen.Add(temp);
                }
                sr.Close();
                */
                XmlSerializer serializer = new XmlSerializer(typeof(List<Mensch>));
                TextReader tr = new StreamReader("menschen.xml");

                menschen = (List<Mensch>)serializer.Deserialize(tr);
                tr.Close();

            //}
            //catch (Exception ex)
            //{ 
            //    Console.WriteLine("Datei konnte nicht gelesen werden!");
            //    throw new Exception();
            //}
            return menschen;
        }

        public List<Mensch> hinzufügen(Mensch temp)
        {
            menschen.Add(temp);

            return menschen;
        }

        public void schreiben()
        {
            try
            {
                /*
                StreamWriter sw = new StreamWriter("Menschen.csv",false,Encoding.UTF8);

                for (int i = 0; i < menschen.Count; i++)
                {
                    sw.WriteLine(menschen[i].Name + ';' + menschen[i].Nachname + ';' + Convert.ToString(menschen[i].Geb));
                }
                sw.Close();
                */

                XmlSerializer serializer = new XmlSerializer(typeof(List<Mensch>));
                TextWriter tw = new StreamWriter("menschen.xml");
                serializer.Serialize(tw, menschen);
                tw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datei konnte nicht gelesen werden!");
                throw new Exception();
            }
        }
    }
}