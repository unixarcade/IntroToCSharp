using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DnsIP
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine("Local hostname: {0}", hostName);
            IPHostEntry myself = Dns.GetHostByName(hostName);
            foreach (IPAddress address in myself.AddressList)
            {
                Console.WriteLine("Ip Adresses: {0}", address.ToString());
            }
            Console.ReadKey();
        }
    }
}
