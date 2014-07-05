using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    class MethodDemo
    {
    static double readValue (
        string prompt,
        double low,
        double high);
    {
        double result = 0;
        do {
        Console.WriteLine (prompt + "between " + low + " and " + high);
        string resultString = Console.ReadLine();
        result  = double.Parse(resultString);
    } while ((result < low)) || (result > high));
    return result;
}

    

 



        static void Main(string[] args)
        {
double age = readValue ("Enter the age : ", 0, 100.0);
Console.WriteLine("Age is : " + age) ;       


}
    }

