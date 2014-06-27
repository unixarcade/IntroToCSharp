using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> lambda = x => x + x;

            var result = lambda(25);
            Console.WriteLine(result);

            result = lambda(50);
            Console.WriteLine(result);

            result = lambda(2 * 2);
            Console.WriteLine(result);
            Console.ReadKey();
        
        
        }
    }
}
