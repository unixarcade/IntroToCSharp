using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silly_Method
{
    class MethodDemo
    {
        static void silly(int i)
        {
            Console.WriteLine("i is : " + i);
        }
            
            static void Main(string[] args)
        {
            silly(101);
            silly(500);
            Console.ReadKey();
            }
    }
}
