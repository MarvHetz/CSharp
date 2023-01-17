using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPizza
{
    public class BestellPosition
    {
        private Int32 id;        
        private Pizza neuePizza;
        private Int32 menge;

        public int Id { get => id; set => id = value; }       
        public int Menge { get => menge; set => menge = value; }
        public Pizza NeuePizza { get => neuePizza; set => neuePizza = value; }
    }
}
