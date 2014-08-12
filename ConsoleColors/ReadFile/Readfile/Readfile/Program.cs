using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Readfile
{
    class Program
    {


        static void ReadFile(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            try
            {
                for (int x = 0; x <= 9; x++)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            finally
            {
                reader.Close();
            }
        }
        static void Main(string[] args)
        {

           
            
                ReadFile("zen.txt");
            
            Console.ReadKey();
        }

    }
}
