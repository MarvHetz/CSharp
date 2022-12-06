using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustierVorlage
{
    public class Mensch
    {
        private bool laune;
        public delegate void launenSpiegel();
        public launenSpiegel guteLaune = null;
        public launenSpiegel schlechteLaune = null;

        public Mensch()
        {
            Laune = true;
        }

        public bool Laune { get => laune; private set => laune = value; }

        public void Arbeiten()
        {
            laune = false;
            if (schlechteLaune != null)
            {
                schlechteLaune();
            }
        }
        public void Fuettern()
        {
            laune = true;
            if (guteLaune != null)
            { 
                guteLaune();
            }
        }

        public void Urlaub()
        {
            laune = true;
            if(guteLaune != null)
            {
                guteLaune();
            }
        }

        public void SauberMachen()
        {
            laune = false;
            if(schlechteLaune != null)
            {
                schlechteLaune();
            }
        }
    }
}
