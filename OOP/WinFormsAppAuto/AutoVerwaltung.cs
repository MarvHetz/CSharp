using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppAuto
{
    internal class AutoVerwaltung
    {
        List<Auto> autos;

        public AutoVerwaltung()
        { 
            Autos = new List<Auto>();
        }

        public List<Auto> Autos { get => autos; set => autos = value; }

        public void Erzeugen(string kz,int kilometerstand, double maxFuellmenge, double verbrauch)
        { 
            Autos.Add(new Auto(kz,kilometerstand,maxFuellmenge,verbrauch));
        }

        public Auto Ausgabe(int index)
        { 
            return autos[index];
        }
    }
}
