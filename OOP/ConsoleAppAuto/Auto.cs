using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuto
{
    class Auto
    {
        private double aktuelleFuellung;
        private int kilometerstand;
        private double maxFuellmenge;
        private double verbrauch;

        public Auto(int kilometerstand, double maxFuellmenge, double verbrauch)
        { 
            this.kilometerstand = kilometerstand;
            this.verbrauch = verbrauch;
            this.maxFuellmenge = maxFuellmenge;
        }

        public double AktuelleFuellung { get => aktuelleFuellung;}
        public int Kilometerstand { get => kilometerstand;}
        public double MaxFuellmenge { get => maxFuellmenge;}
        public double Verbrauch { get => verbrauch;}

        public int Fahren(int anzahlKm)
        {
            if ((100 / verbrauch) * aktuelleFuellung < anzahlKm)
            {
                anzahlKm = Convert.ToInt32((100 / verbrauch) * aktuelleFuellung);
                Console.WriteLine(anzahlKm);
                kilometerstand += anzahlKm;
                aktuelleFuellung = 0;
            }
            else
            {
                aktuelleFuellung -= Convert.ToDouble(anzahlKm / 100) * verbrauch;
                kilometerstand += anzahlKm;
                Console.WriteLine(aktuelleFuellung);
            }

            return anzahlKm;
        }

        public double Tanken(double menge)
        {
            double rest = maxFuellmenge - aktuelleFuellung;
            if (rest < menge)
            {
                Console.WriteLine("Sie tanken zu viel!");
                menge -= rest;
            }

            aktuelleFuellung += menge;

            return menge;
        }
    }
}
