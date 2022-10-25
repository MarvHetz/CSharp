using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW
{
    internal class Program
    {
        static void eingabe()
        {
            Console.WriteLine("Geben Sie ihre Kilowattanzahl ein: ");
            double KW = Convert.ToDouble(Console.ReadLine());

            double PS = KW * 1.36;

            Console.WriteLine("Die PSzahl ist: {0}.",PS);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            eingabe();
        }
    }
}
