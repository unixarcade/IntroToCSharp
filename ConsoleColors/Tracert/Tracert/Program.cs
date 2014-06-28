using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


namespace Tracert
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping pinger = new Ping();
            String data = "0123456789ABCDEF";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            PingOptions options = new PingOptions();

            IPHostEntry target = Dns.GetHostEntry(args[0]);
            bool isDestination = false;
            for (int i = 1; i <= 30; i++)
            {
                String intermediateHost = null;
                for (int j = 0; j < 3; j++)
                {
                    options.Ttl = i;
                    PingReply reply = pinger.Send(target.AddressList[0], 30, buffer, options);
                    switch (reply.Status)
                    {
                        case IPStatus.TimedOut:
                        case IPStatus.TtlExpired:
                        case IPStatus.Success:
                            Console.Write("<{0}ms\t", reply.RoundtripTime);

                            if (reply.Address.Equals(target.AddressList[0]))
                            {
                                isDestination = true;
                            }
                            intermediateHost = reply.Address.ToString();
                            break;
                        default:
                            Console.WriteLine("*\t");
                            break;
                    }
                }
                    Console.WriteLine("\t{0}", intermediateHost);
                            if (isDestination)
                            {
                                break;
                            } //javascript:void(0);
                    }
                    pinger.Dispose();

                    }

                
                    }
                }
            
}