using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 1 + 1;
            var today = DateTime.Now;

            var flag = true;
                if(flag)
                {
                    Console.WriteLine("Flag is not true");
                }

                
            if (1 + 1 == 2)
            {
                Console.WriteLine("Flag is not true");
            }

            if ( x != 2)
            {
                Console.WriteLine("Flag is not true");
            }
            if ( x == 2)
            {
                Console.WriteLine("X is 2");
            }
            else
            {
                Console.WriteLine("X is not 2");
            }

            if (x == 2)
            {
                Console.WriteLine("X is 2");

            }
            else if (x == 3)
            {
                Console.WriteLine("x is 3");
            }
            else if (x == 5)
            {
                Console.WriteLine("X is 5");
            }
            else
            {
                Console.WriteLine("X is not 2");
            }

            switch (x)
            {
                case 2:
                    Console.WriteLine("X is 2");
                    Console.WriteLine(x);
                    break;
                
                case 3:
                    Console.WriteLine("X is 3");
                    break;

                default:
                    Console.WriteLine("X is not 2 or 3");
                    break;
            }

           var y = x == 2 ?  true: false ;
           var z = x == 2 ? "x is two" : "x is not two";


           for (var idx = 0; idx < 1000; idx++)
           {
               Console.WriteLine("The number is " + idx);}

           for (var idx = 1000; idx >= 0; idx = idx - 1)
           {
               Console.WriteLine("The number is" + idx);
           }

           var list = new List<int>();
           list.Add(1);
           list.Add(2);
           list.Add(3);


           var len = list.Count();

            foreach (var myNumber in list)
            {
                Console.WriteLine("Current number is " + myNumber);
            }

            var mylist = new List<string>();
            mylist.Add("Luminosity");
            mylist.Add("Bruce Wayne");
            mylist.Add("Wolverine");

            var nlen = mylist.Count();
            Console.WriteLine(mylist[0]);
            Console.WriteLine(mylist[1]);
            Console.WriteLine(mylist[2]);
           //foreach (var nlen in mylist)
           // {
           //     Console.WriteLine("Super Heros" + nlen);
           // }
            

            Console.ReadKey();
        }
       
        
    }
    }

