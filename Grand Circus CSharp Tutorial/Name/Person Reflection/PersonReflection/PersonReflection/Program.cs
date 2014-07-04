using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonReflection
{
    class Person
    {
        private int age = -1;
        private string name = String.Empty;

        public void Load()
        {
            Type type = this.GetType();
            string propertyName, value;
            string[] temp;
            char[] splitChars = new char[] { '|' };
            PropertyInfo propertyInfo;

            string[] settings = File.ReadAllLines("settings.dat");
            foreach (string s in settings)
            {
                temp = s.Split(splitChars);
                if (temp.Length == 2)
                {
                    propertyName = temp[0];
                    value = temp[1];
                    propertyInfo = type.GetProperty(propertyName);
                    if (propertyInfo != null)
                        this.SetProperty(propertyInfo, value);
                }
            }
        }

        public void Save()
        {
            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            TextWriter tw = new StreamWriter("settings.dat");
            foreach (PropertyInfo propertyInfo in properties)
            {
                tw.WriteLine(propertyInfo.Name + "|" + propertyInfo.GetValue(this, null));
            }
            tw.Close();
        }

        public void SetProperty(PropertyInfo propertyInfo, object value)
        {
            switch (propertyInfo.PropertyType.Name)
            {
                case "Int32":
                    propertyInfo.SetValue(this, Convert.ToInt32(value) null);
          break;

                case "String":
                    propertyInfo.SetValue(this, value.ToString(), null);
                    break;
            
            
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Load();
            if((person.Age > 0) && (person.Name != String.Empty))
            {
                Console.WriteLine("Hi " + person.Name + " - you are " + person.Age + " years old!");
            }
            else
            {
                Console.WriteLine("I don't seem to know much about you. Please enter the following information:");
                Type type = typeof(Person);
                PropertyInfo[] properties = type.GetProperties();
                foreach(PropertyInfo propertyInfo in properties)
                {
                    Console.WriteLine(propertyInfo.Name + ":");
                    person.SetProperty(propertyInfo, Console.ReadLine());
                    Console.ReadLine());
                }
            
            
            person.Save();
                Console.WriteLine("Thank you! I have saved your information for next time.");
            }
            Console.ReadKey();
            }



        }
    }


