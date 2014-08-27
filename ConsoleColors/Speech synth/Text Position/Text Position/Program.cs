using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int txtpos = 50;
            string mymammy = "Pumpkin Pie";
            string says = "Sho Nuff!";


            Console.CursorLeft = txtpos;

            Console.WriteLine(" My Mammy eats {0} {1}", mymammy, says);

            Console.ReadKey();



        }
    }
}
