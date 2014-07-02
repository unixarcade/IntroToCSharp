using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{

    public enum Days {  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}


    class Program
    {
        static void Main(string[] args)
        {
            Days day = Days.Monday;
            Console.WriteLine((int)day);
            Console.ReadLine();



        }
    }
}
