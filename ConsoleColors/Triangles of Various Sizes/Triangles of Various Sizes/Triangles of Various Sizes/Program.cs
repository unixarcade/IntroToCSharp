using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles_of_Various_Sizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number of lines you want your triangle to be below.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }

            Console.ReadKey();
        }

        static void PrintLine(int start, int end)
        {
            for(int i = start; i<= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
