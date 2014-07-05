using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Demo
{
    

        class  Return_Demo{
            static int sillyReturnPlus(int i)
            {
                i = i + 1;
                Console.WriteLine("i is : " + i);
                return i;
            }


        static void Main(string[] args)
        {
            int res;
            res = sillyReturnPlus(5);
            Console.WriteLine("res is : " + res);

            Console.ReadKey();
        
        }
    }
}
