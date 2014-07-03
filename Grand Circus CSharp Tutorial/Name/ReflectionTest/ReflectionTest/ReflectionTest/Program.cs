using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] assemblyTypes = assembly.GetTypes();
            foreach(Type t in assemblyTypes)
            {
                Console.WriteLine(t.Name);
                Console.ReadKey();
            }

        }
    }
}

class DummyClass
{
    // Wee output
}