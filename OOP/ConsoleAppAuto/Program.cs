using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto wagen = new Auto(156345,80,8.5);

            Console.WriteLine("KM-Stand vor der Fahrt: " + wagen.Kilometerstand);
            wagen.Tanken(50);
            Console.WriteLine("Aktuelle Tankfüllung: " + wagen.AktuelleFuellung);

            do
            {
                int km = wagen.Fahren(300);
                if (km == 300)
                {
                    Console.WriteLine("Aktueller km-Stand {0} nach 300 km.", wagen.Kilometerstand);
                }
                else
                {
                    Console.WriteLine("Es können nur {0} km zurückgelegt werden", km);
                }
            }while (wagen.AktuelleFuellung != 0);

            Console.WriteLine("KM-Stand nach der Fahrt: " + wagen.Kilometerstand);
            Console.WriteLine("Aktuelle Tankfüllung: " + wagen.AktuelleFuellung);

            Console.ReadKey();
        }
    }
}
