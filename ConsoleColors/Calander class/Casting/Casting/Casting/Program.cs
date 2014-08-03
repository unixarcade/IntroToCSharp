using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class CastDemo
    {
        static void Main(string[] args)
        {
            int i = 3, j = 2;

       
            float fraction;
            fraction = (float)i / (float)j;
            Console.WriteLine("fraction : " + fraction);
            Console.ReadKey();

        }
    }
}
