using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEimer
{

    internal class Eimer
    {
        private int maxFuellmenge;
        private int aktFuellmenge;
        public delegate void FillError(string fehlermeldung);
        public FillError onFillError;

        public Eimer()
        {
            AktFuellmenge = 0;
        }

        public Eimer(int maxFuellmenge) : this()
        { 
            this.MaxFuellmenge = maxFuellmenge;
        }

        public int MaxFuellmenge { get => maxFuellmenge; set => maxFuellmenge = value; }
        public int AktFuellmenge { get => aktFuellmenge; set => aktFuellmenge = value; }

        public void Einfuellen(int menge)
        {
            if (this.aktFuellmenge + menge > maxFuellmenge)
            {
                if (onFillError != null)
                {
                    onFillError("Die MaximaleFuellmenge ist erreicht!");
                }
                aktFuellmenge = maxFuellmenge;
            }
            else
            {
                aktFuellmenge += menge;
            }
        }
    }
}
