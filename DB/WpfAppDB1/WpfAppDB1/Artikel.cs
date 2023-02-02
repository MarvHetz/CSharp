using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDB1
{
    public class Artikel
    {
        private int id;
        private string name;
        private decimal preis;

        public Artikel()
        { }

        public Artikel(string name, decimal preis)
        {
            this.name = name;
            this.preis = preis;
        }

        public Artikel(int id, string name, decimal preis)
        {
            this.id = id;
            this.name = name;
            this.preis = preis;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Preis { get => preis; set => preis = value; }

        public override string ToString()
        {
            return id + " " + name + " " + preis;
        }
    }
}
