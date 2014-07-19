using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace NicCardGrab
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey start = Registry.LocalMachine;
            RegistryKey cardServiceName, networkKey;
            string networkcardKey = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkCards";
            string serviceKey = "SYSTEM\\CurrentControlSet\\Services\\";
            string networkcardKeyName, deviceName;
            string deviceServiceName, serviceName;
            RegistryKey serviceNames = start.OpenSubKey(networkcardKey);

            if (serviceNames == null)
            {
                Console.WriteLine("Bad registry key");
                return;
            }
            string[] networkCards = serviceNames.GetSubKeyNames();
            serviceNames.Close();
            foreach (string keyName in networkCards)
            {
                networkcardKeyName = networkcardKey + "\\" + keyName;
                cardServiceName = start.OpenSubKey(networkcardKeyName);
                if (cardServiceName == null)
                {
                    Console.WriteLine("Bad registry key: {0}", networkcardKeyName);
                    return;
                }
                deviceServiceName = (string)cardServiceName.GetValue("ServiceName");
                deviceName = (string)cardServiceName.GetValue("Description");
                Console.WriteLine("\nNetwork card: {0}", deviceName);

                serviceName = serviceKey + deviceServiceName + "\\Parameters\\Tcpip";
                networkKey = start.OpenSubKey(serviceName);
                if (networkKey == null)
                {
                    Console.WriteLine(" No Ip configuration set");
                }
                else
                {
                    string[] ipaddresses = (string[])networkKey.GetValue("IPAddress");
                    string[] defaultGateways = (string[])networkKey.GetValue("DefaultGateway");
                    string[] subnetmasks = (string[])networkKey.GetValue("SubnetMask");

                    foreach(string ipaddress in ipaddresses)
                    {
                        Console.WriteLine(" Ip address: {0}", ipaddress);
                    }
                    foreach (string subnetmask in subnetmasks)
                    {
                        Console.WriteLine(" Subnet Mask: {0}", subnetmask);

                    }
                    foreach (string defaultGateway in defaultGateways)
                    {
                        Console.WriteLine(" Gateway: {0}", defaultGateway);
                    }
                    networkKey.Close();
                }
            }
            start.Close();
        
        
        }
    }
}
