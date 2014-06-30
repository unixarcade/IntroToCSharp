using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameloop
{
    class gameloop
    {
        static void Main(string[] args)
        {
            string myn;
            bool mybool;
            mybool = false;
            do
            {
                Console.WriteLine("I live");


                Console.WriteLine("If you Enter YES you will quit the program");
                myn = Console.ReadLine();
                myn = myn.ToUpper();
                if (myn == "YES")
                {
                    mybool = true;
                }

            } while (mybool == false);
        
        }
    }
}
