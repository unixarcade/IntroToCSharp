using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Please enter the name for your letter: ");
            string person = Console.ReadLine();

            Console.Write(" What is the name of your book: ");
            string book = Console.ReadLine();

            string from = " Dreaming Gods";

            Console.WriteLine("  Dear {0},", person);
            Console.Write("We are pleased to inform " + "you that \"{1}\" is the best book. {2}" +
                "The authors of the book wish you good luck {0}!{2}", person, book, Environment.NewLine);

            Console.WriteLine("  Yours,");
            Console.WriteLine("  {0}", from);


            Console.ReadKey();
        }
    }
}
