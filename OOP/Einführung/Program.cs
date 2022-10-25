using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMensch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensch ich = new Mensch("Marvin","Hetzer",17);

            Console.WriteLine("Hallo {0} {1}, Sie sind {2} Jahre alt",ich.Vorname,ich.Nachname,ich.Alter);
            Console.ReadKey();

            Console.WriteLine("Herzlichen Glückwünsch zum {0}. Geburtstag",ich.Geburtstag());

            Console.ReadKey();

            ich.Heiraten("Test");

            Console.WriteLine("Herrzlichen Glückwünsch. Du bist jetzt {0} und heißt {1}", ich.Familienstand, ich.Nachname);

            Console.ReadKey();
        }
    }
}
