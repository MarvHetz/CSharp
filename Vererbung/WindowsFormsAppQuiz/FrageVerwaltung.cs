using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsAppQuiz
{
    internal class FrageVerwaltung
    {
        List<Frage> fragen;

        public FrageVerwaltung()
        {
            Lesen();
        }

        internal List<Frage> Fragen { get => fragen; set => fragen = value; }

        private void Lesen()
        {
            XmlSerializer seriliazer = new XmlSerializer(typeof(List<Frage>));

            try
            {
                StreamReader sr = new StreamReader("Fragen.xml", Encoding.UTF8);

                fragen = (List<Frage>)seriliazer.Deserialize(sr);
            }
            catch (FileNotFoundException)
            { 
                Console.WriteLine("Datei konnte nicht gelesen werden!!!");
            }
            catch (IOException ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
