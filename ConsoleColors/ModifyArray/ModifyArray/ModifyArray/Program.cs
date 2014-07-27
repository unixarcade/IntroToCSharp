using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyArray
{
    class Program
    {


        static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the param is: ");
            PrintArray(arrParam);
        }

        static void PrintArray(int[] arrParam)
        {
            Console.Write("[");
            int length = arrParam.Length;

            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }


        static void Main(string[] args)
        {
            int[] arrArg = new int[] { 1, 2, 3 };
            Console.Write("Before ModifyArray() the argument is: ");
            PrintArray(arrArg);

            Console.Write("After ModifyArray() the argument is: ");
            PrintArray(arrArg);


            Console.ReadKey();

        }
    }
}
