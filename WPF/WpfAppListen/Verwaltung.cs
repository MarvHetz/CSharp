using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppListen
{
    public class Verwaltung
    {
        private List<Person> personen;

        public Verwaltung()
        { 
            Personen = new List<Person>();
            Personen.Add(new Person("Kai",22,"Pferd"));
            Personen.Add(new Person("Frederik",19,"Meerschweinchen"));
            Personen.Add(new Person("Christian", 17, "Kamel"));
            Personen.Add(new Person("Alfons", 27, "Schildkröte"));
        }

        public List<Person> Personen { get => personen; set => personen = value; }
    }
}
