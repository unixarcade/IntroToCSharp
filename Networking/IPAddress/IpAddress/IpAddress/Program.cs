using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IpAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress test1 = IPAddress.Parse("192.168.1.1");

            IPAddress test2 = IPAddress.Loopback;

            IPAddress test3 = IPAddress.Broadcast;

            IPAddress test4 = IPAddress.Any;

            IPAddress test5 = IPAddress.None;

            IPHostEntry ihe = Dns.GetHostByName(Dns.GetHostName());
            IPAddress myself = ihe.AddressList[0];
            if (IPAddress.IsLoopback(test2))
            {
                Console.WriteLine(" The Loopback address is: {0}", test2.ToString());
            }
            else
            {
                Console.WriteLine("Error obtaining the loopback addresses");
               
            }
            Console.WriteLine(" The Local IP address is: {0}\n", myself.ToString());

            if (myself == test2)
            {
                Console.WriteLine(" The Loopback address is the same as local address. \n");

            }
            else
            {
                Console.WriteLine(" The loopback address is not the local address.\n");
            }

            Console.WriteLine(" The test address is: {0}", test1.ToString());
            Console.WriteLine(" Broadcast address: {0}", test3.ToString());
            Console.WriteLine(" The ANY address is: {0}", test4.ToString());
            Console.WriteLine(" The NONE address is: {0}", test5.ToString());


            Console.ReadKey();

        }
    }
}
