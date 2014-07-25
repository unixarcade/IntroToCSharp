using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLogo
{
    class Program
    {
        
        
        static void PrintCompanyInformation()
        {
            PrintLogo();

            Console.WriteLine("Address: The Data");
        }

        static void PrintLogo(){
            Console.WriteLine("Luminosity");
            Console.WriteLine("Address: The Data");

            // For a stackoverflow exception uncomment 
            // PrintCompanyInformation();
        }

        static void Main(string[] args)
        {
            PrintLogo();

            Console.ReadKey();
        }
    }
}
