using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

            foreach (string name in list)
                Console.WriteLine(name);

            Console.ReadLine();
        
        }
    }
}
