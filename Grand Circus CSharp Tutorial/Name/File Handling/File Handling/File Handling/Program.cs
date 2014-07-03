using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file: ");
                Console.WriteLine(content);


            }
            Console.WriteLine("Please enter new content for the file: ");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);

        }
    }
}
