using System;
using System_Generics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            dogs.Sort();

            foreach (Dog dog in dogs)
                Console.WriteLine(dog.Describe());
            Console.ReadKey();
        
        
        }
    }


    interface IAnimal
    {
        string Describe();

        string Name
        {
            get;
            set;
        }

        class Dog : IAnimal, IComparable
        {
            private string name;

            public Dog(string name)
            {
                this.name = name;
            }

            public string Describe()
            {
                return "Hello, I am a dog and my name is " + this.name;
            }

            public int CompareTo(object obj)
            {
                if (obj is IAnimal)
                    return this.name.CompareTo((obj as IAnimal).Name);
                return 0;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
    }
}
