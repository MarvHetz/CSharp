using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppEinfacheÜbung
{
    public class Tier
    {
        private int id;
        private string art;
        private string name;
        private int alter;
        private string vermittelt;

        public Tier(int id, string art, string name, int alter, Boolean vermittelt)
        {
            this.id = id;
            this.art = art;
            this.name = name;
            this.alter = alter;
            if (vermittelt)
            {
                this.vermittelt = "Sucht kein Herrchen";
            }
            else
            {
                this.vermittelt = "Sucht ein Herrchen";
            }
        }

        public int Id { get => id; set => id = value; }
        public string Art { get => art; set => art = value; }
        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public string Vermittelt { get => vermittelt; set => vermittelt = value; }

        public override string ToString()
        {
            return art + " " + name;
        }
    }
}
