using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        public string ignore(string word)
        {
            word = word.Replace(" ","");   
            word = word.ToLower();

            return word;
        }

        public string reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Geben Sie bitte ein Wort ein: ");
            //string word = Console.ReadLine();

            //string upper = word.ToUpper();
            //Console.WriteLine("Das Wort in Groß ist: {0}",upper);

            //int length = word.Length;
            //Console.WriteLine("Die Länge des Wortes ist: {0}",length);

            //string copy = word;
            //Console.WriteLine(copy);

            //Console.WriteLine("Geben Sie ein neues Wort ein: ");
            //string newword = Console.ReadLine();

            //if(word == newword)
            //{
            //    Console.WriteLine("Die Wörter sind gleich!");
            //}
            //else
            //{
            //    Console.WriteLine("Die Wörter sind ungleich!");
            //}

            Console.WriteLine("Bitte geben Sie ein Wort ein: ");
            string word = Console.ReadLine();

            word = ignore(word);

            string reversed = reverse(word);

            if (reversed == word)
            {
                Console.WriteLine("Es ist ein Palindrom");
            }
            else
            {
                Console.WriteLine("Es ist kein Palindrom");
            }

            Console.ReadKey();
        }
    }
}