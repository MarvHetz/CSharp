using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihren Namen ein: ");
            string name = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihr Alter ein: ");
            int alter = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0},{1}",name,alter);

            Console.ReadKey();
        }
    }
}
