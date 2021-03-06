﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Fibonacci
{
    class Program
    {
        static long Fib(int n)
        {
            if(n<=2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }


        static void Main(string[] args)
        {
            Console.Write(" N = ");
            int n = int.Parse(Console.ReadLine());

            long result = Fib(n);
            Console.WriteLine("fib({0}) = {1}", n, result);

            Console.ReadKey();
        }
    }
}
