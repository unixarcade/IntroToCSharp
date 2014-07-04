using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NextReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Type testType = typeof(TestClass);
            ConstructorInfo ctor = testType.GetConstructor(System.Type.EmptyTypes);
            if (ctor != null)
            {
                object instance = ctor.Invoke(null);
                MethodInfo methodInfo = testType.GetMethod("Test Method");
            }
            Console.WriteLine(MethodInfo.Invoke(instance, new object[] { 10 }));
            Console.ReadKey();
        }
        
        }
    }

public class TestClass
{
    private int testValue = 42;

    public int TestMethod(int numberToAdd){
        return this.testValue + numberToAdd;
    }
}
