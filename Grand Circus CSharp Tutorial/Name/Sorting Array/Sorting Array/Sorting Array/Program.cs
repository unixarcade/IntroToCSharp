using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Array
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 8, 0, 5 };
            Array.Sort(numbers);

            foreach(int i in numbers)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
