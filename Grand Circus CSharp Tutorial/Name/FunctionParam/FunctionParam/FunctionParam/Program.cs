using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParam
{
    class Program
    {

        static void AddFive(ref int number)
        {
            number = number + 5;
           
        }
        static void Main(string[] args)
        {
            int number = 20;
            AddFive(ref number);
            Console.WriteLine(number);
            Console.ReadKey();
        
        }

       

        

    }
}
