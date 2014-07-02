using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Please enter a number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you one more: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adding the two numbers: " + (number1 + number2));
        Console.ReadLine();

        
        }
    }
}
