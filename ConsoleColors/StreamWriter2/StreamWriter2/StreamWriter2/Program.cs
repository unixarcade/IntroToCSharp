using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" Word Salad ");
            using (StreamWriter writer =
            new StreamWriter("imp.txt"))
            {
                TextWriter("Word ");
                TextWriter(" Salad ");
            }

            
            Console.ReadKey();


        }

        private static void TextWriter(string p)
        {
            //throw new NotImplementedException();
        }

        
    
    }
}
