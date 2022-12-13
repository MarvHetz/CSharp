using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace WindowsFormsAppQuiz
{
    internal class Antwort
    {
        private string anwortmoeglichkeit;
        private bool richtig;

        public Antwort()
        { 
        }

        public Antwort(string anwortmoeglichkeit, bool richtig)
        {
            this.Anwortmoeglichkeit = anwortmoeglichkeit;
            this.Richtig = richtig;
        }

        public string Anwortmoeglichkeit { get => anwortmoeglichkeit; set => anwortmoeglichkeit = value; }
        public bool Richtig { get => richtig; set => richtig = value; }
    }
}