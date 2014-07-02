using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Describe());
            Console.ReadKey();

        
        
        
        
        
        }
    abstract class FourLeggedAnimal
    {
        public virtual string Describe()
        {
            return "Not much is known about this for legged being. ";
        }
    }
    class Dog : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "This four legged animal is a Dog";
        }
    }
    
    
    
    
    
    }




}
