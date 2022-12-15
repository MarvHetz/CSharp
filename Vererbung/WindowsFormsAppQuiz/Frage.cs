using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppQuiz
{
    public class Frage
    {
        private List<Antwort> antworten;
        private String fragestellung;

        public Frage()
        { 
            antworten = new List<Antwort>();
        }

        public string Fragestellung { get => fragestellung; set => fragestellung = value; }
        public List<Antwort> Antworten { get => antworten; set => antworten = value; }

        public override string ToString()
        {
            return fragestellung;
        }

        public void Loesen(Antwort antwort)
        { }
    }
}