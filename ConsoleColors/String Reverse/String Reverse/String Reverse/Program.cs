using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverse
{
    class Program
    {

        public static string teststringsplit(string mystring){
        string[] delimeterChars = {" ", ",",".", ":", "\t" };
        string[] words = mystring.Split(delimeterChars);
        Console.WriteLine("Original text:  '{0}'", mystring);
        foreach (string s in mystring)
    {
        Console.WriteLine(s);
    }
}
     public  static  string mMethodReverse(string mystring)
        {
         string output = "";
         for (int i = mystring.Length - 1; i>=0; i-- ){
                output += mystring[i];
         }

         return output;
    }

        public static string mWordReverse(string mystring)
     {
         
         
        
         
          int  mystringlength = mystring.Length;
         
         string myreverse = mystring.Substring(0, mystringlength);
        
           
            return myreverse;
     }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input string to be reversed ");
            string readmyline;
            readmyline = Console.ReadLine();
            
            Console.WriteLine(mMethodReverse(readmyline));
            Console.ReadKey();
        
        }
    }
}
