using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppAuto
{
    public class Auto
    {
        private double aktuelleFuellung;
        private int kilometerstand;
        private double maxFuellmenge;
        private double verbrauch;
        private string kz;

        public Auto(string kz,int kilometerstand, double maxFuellmenge, double verbrauch)
        { 
            this.Kz = kz;
            this.Kilometerstand = kilometerstand;
            this.Verbrauch = verbrauch;
            this.MaxFuellmenge = maxFuellmenge;
        }

        public double AktuelleFuellung { get => aktuelleFuellung; set => aktuelleFuellung = value; }
        public int Kilometerstand { get => kilometerstand; set => kilometerstand = value; }
        public double MaxFuellmenge { get => maxFuellmenge; set => maxFuellmenge = value; }
        public double Verbrauch { get => verbrauch; set => verbrauch = value; }
        public string Kz { get => kz; set => kz = value; }

        public int Fahren(int anzahlKm)
        {
            if ((100 / Verbrauch) * AktuelleFuellung < anzahlKm)
            {
                anzahlKm = Convert.ToInt32((100 / Verbrauch) * AktuelleFuellung);
                Console.WriteLine(anzahlKm);
                Kilometerstand += anzahlKm;
                AktuelleFuellung = 0;
            }
            else
            {
                AktuelleFuellung -= Convert.ToDouble(anzahlKm / 100) * Verbrauch;
                Kilometerstand += anzahlKm;
                Console.WriteLine(AktuelleFuellung);
            }

            return anzahlKm;
        }

        public double Tanken(double menge)
        {
            double rest = MaxFuellmenge - AktuelleFuellung;
            if (rest < menge)
            {
                Console.WriteLine("Sie tanken zu viel!");
                menge -= rest;
            }

            AktuelleFuellung += menge;

            return menge;
        }

        public override string ToString()
        {
            return Kz.ToString();
        }
    }
}
