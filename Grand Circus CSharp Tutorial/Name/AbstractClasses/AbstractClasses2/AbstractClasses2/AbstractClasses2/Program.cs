using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList animalList = new
            System.Collections.ArrayList();
            animalList.Add(new Dog());
            animalList.Add(new Cat());

            foreach (FourLeggedAnimal animal in animalList)
                Console.WriteLine(animal.Describe());
            Console.ReadKey();
        }


        abstract class FourLeggedAnimal
        {
            public abstract string Describe();
        }

        class Dog : FourLeggedAnimal
        {

            public override string Describe()
            {
                return "I'm a dog! Woof! Woof!";
            }
        }
        class Cat : FourLeggedAnimal
            {
                public override string Describe()
                {
                    return "I'm a cat!";
                }
            }
        }
    }

