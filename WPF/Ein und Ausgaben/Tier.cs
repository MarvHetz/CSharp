using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ein_und_Ausgaben
{
    public class Tier
    {
        private string name;

        public Tier()
        {
            name = "Garret";
        }

        public string Name { get => name; set => name = value; }

        public string Message()
        {
            name = "Dante";
            return name + " : Salve";
        }
    }
}
