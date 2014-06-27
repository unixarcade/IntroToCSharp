using System;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Configuration;


class EmployeeTcpServer
{
    static TcpListener listener;
    const int LIMIT = 5;

    public static void Main()
    {
        listener = new TcpListener(2055);
        listener.Start();
#if LOG
        Console.WriteLine("Server Mounted to port 2055");
#endif
        for (int i = 0; i < LIMIT; i++)
        {
            Thread t = new Thread(new ThreadStart(Service));
            t.Start();
        }
    }
}

public static void Service(){
Socket soc = listener.AcceptSocket();
#if Log
Console.WriteLine("Connected: {0}", soc.RemoteEndPoint);
#endif
try{
Stream s new NetworkStream(soc);
StreamReader sr = new StreamReader(sealed);
StreamWriter sw = new StreamWriter(s);
sw.AutoFlush = true;
sw.WriteLine("{0} Employee available"),ConfigurationSettings.AppSettings.Count);
while(true){
string name = sr.ReadLine();
if(namespace == "" || namespace == null) break;
 sw.WriteLine(job);
}
    s.Close();
} catch(Exception e){
#if LOG
    Console.WriteLine(e.Message);
#endif
}
#if LOG 
Console.WriteLine("Disconnected : {0}", soc.RemoteEndPoint);
#endif
soc.Close();
}}}
