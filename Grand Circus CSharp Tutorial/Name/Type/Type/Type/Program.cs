using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "test";
            Console.WriteLine(test.GetType().FullName);
            Console.WriteLine(typeof(Int32).FullName);
            Console.ReadKey();
        }
    }
}
