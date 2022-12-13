using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDelegateEinführung
{
    class Vorschlaege
    {
        List<string> liste;
        public delegate void MaxVorschlaegeErreicht(string Fehlermeldung);
        public MaxVorschlaegeErreicht OnmaxVorschlaegeErreicht = null;

        public List<string> Liste { get => liste; private set => liste = value; }

        public Vorschlaege()
        {
            liste = new List<string>();
        }
        public void VorschlagAufnehmen(string Vorschlag)
        {
            if (liste.Count < 3)
            {
                liste.Add(Vorschlag);
            }
            else
            {
                if (OnmaxVorschlaegeErreicht != null)
                {
                    OnmaxVorschlaegeErreicht("Das sind zu viele Vorschläge!");
                }
            }
            
        }
        public void AlleLoeschen()
        {
            liste.Clear();
        }
    }
}
