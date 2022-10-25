using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensoftware
{
    internal class Program
    {
        static void eingabe()
        {
            Console.WriteLine("Bitte geben Sie ihren Geldbetrag ein: ");
            float geldbetrag = Convert.ToSingle(Console.ReadLine());

            if (geldbetrag > 5)
            {
                Console.WriteLine("Bitte geben Sie einen Betrag unter 5€ ein!");
                eingabe();
            }
            else if (geldbetrag <= 0) 
            {
                Console.WriteLine("Bitte geben Sie einen echten Betrag ein!");
                eingabe();
            }
            else
            {
                rechnen(Convert.ToInt32(geldbetrag*100));
            }
        }

        static void rechnen(int geldbetrag)
        {
            Console.WriteLine(geldbetrag);

            int euro2 = geldbetrag / 200;
            geldbetrag %= 200;
            Console.WriteLine(geldbetrag);
            
            int euro1 = geldbetrag / 100;
            geldbetrag %= 100;

            int cent50 = geldbetrag / 50;
            geldbetrag %= 50;

            int cent20 = geldbetrag / 20;
            geldbetrag %= 20;

            int cent10 = geldbetrag / 10;
            geldbetrag %= 10;

            int cent5 = geldbetrag / 5;
            geldbetrag %= 5;

            int cent2 = geldbetrag / 2;

            int cent1 = geldbetrag % 2;

            Console.WriteLine("2 Euro: {0}\n1 Euro: {1}\n50 Cent: {2}\n20 Cent: {3}\n10 Cent: {4}\n5 Cent: {5}\n2 Cent: {6}\n1 Cent: {7}\nVielen Dank fürs Benutzen!",euro2,euro1,cent50,cent20,cent10,cent5,cent2,cent1);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            eingabe();
        }
    }
}
