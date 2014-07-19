using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFile = "Logfile.txt";
            FileStream fs = new FileStream(logFile, FileMode.OpenOrCreate, FileAccess.Write);
           using( StreamWriter sw = new StreamWriter(fs));
            StreamReader sr = new StreamReader(fs);
            sw.WriteLine("First log entry");
            sw.WriteLine("Second log entry");
            while(sr.Peek() > - 1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sw.Close();
            sr.Close();
            fs.Close();
        }
    }
}
