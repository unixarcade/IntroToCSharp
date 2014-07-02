using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[7];

            names[0] = "John Doe";
            names[1] = "Jane Doe";
            names[2] = "Captain Kirk";
            names[3] = "Spock";
            names[4] = "Luminosity";
            names[5] = "Hussein";
            names[6] = "Bill Wagner";

            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
                Console.ReadLine();
            }
        
        
        
        }
    }
