using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 8, c = 233;
            int d = a + c - b;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
