using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            try
            { 
            numbers[0] = 23;
            numbers[1] = 32;
            numbers[2] = 42;

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
                catch
            {
               Console.WriteLine("Something went wrong!");
                }

            
    }
}
    }
}}
}
