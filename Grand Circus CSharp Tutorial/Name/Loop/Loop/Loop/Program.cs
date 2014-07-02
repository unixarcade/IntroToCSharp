using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = 0;
            while (number < 10000000000000000000)
            {
                Console.WriteLine(number + " " + number+" " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);

                number = number + 111111111111111;

            }
            Console.ReadLine();
        }
    }
}
