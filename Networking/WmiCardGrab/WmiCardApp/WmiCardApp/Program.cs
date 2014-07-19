using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Management.ManagementObjectCollection;
namespace WmiCardApp
{

    public class ManagementObjectCollection : ICollection, IEnumerable, IDisposable 
    { }
    class Program
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher query = new
            ManagementObjectSearcher("Select * From A Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
            ManagmentObjectCollection queryCollection = query.Get();

            foreach(ManagementObject mo in queryCollection)
            {
                string[] addresses = (string[])mo["IPAdress"];
                string[] subnets = (string[])mo["IPSubnet"];
                string[] defaultgateways = (string[])mo["DefaultIPGateway"];

                Console.WriteLine(" Network Card:  {0}",mo[Description]);
                Console.WriteLine(" MAC Address:  {0}",mo["MACAdress"]);

                foreach(string ipaddress in addresses){
                    Console.WriteLine(" Ip Adress {0}", ipaddress);
                    
                }
foreach(string subnet in subnets){
    Console.WriteLine(" Subnet Mask  {0}", subnet);
}

                foreach(string defaultgateway in defaultgateways)
                {
                    Console.WriteLine( " Gateway: {0}", defaultgateway);
                }







            }

        }
    }
}
