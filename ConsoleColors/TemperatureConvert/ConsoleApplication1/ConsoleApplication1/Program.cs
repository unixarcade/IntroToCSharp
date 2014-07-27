using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static double ConvertFtoC(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter temp in Fahrentheight degrees: ");
            double temperature = double.Parse(Console.ReadLine());

            temperature = ConvertFtoC(temperature);

            Console.WriteLine(" Your Temp in Celsius Degrees is {0}.", +temperature);

            if(temperature >=37)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" We are getting hot");
            }
            else if (temperature >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Getting Colder Now");
            }
            Console.ReadKey();
        }
    }
        
}
