using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = new int[11];
            for (int i = 0; i < 11; i = i + 1)
            {

                
                string scoreString = Console.ReadLine();
                scores[i] = int.Parse(scoreString);
                Console.WriteLine("Score is : " + scores[i]);

            }

            for (int i = 0; i < 11; i++ )
            {
                Console.WriteLine(scores[i]);
            }
            
                Console.ReadKey();

        }
    }
}
