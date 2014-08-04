using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeNestedLoops
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void Main(string[] args)
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            NestedLoops();


        }
    
    static void NestedLoops()
        {
            InitLoops();
            int currentPosition;

        while(true)
        {
            PrintLoops();

            currentPosition = numberOfLoops - 1;
            loops[currentPosition] = loops[currentPosition] + 1;

            while(loops[currentPosition] > numberOfIterations)
            {
                loops[currentPosition] = 1;
                currentPosition--;


                if(currentPosition < 0)
                {
                    return;
                }
                loops[currentPosition] = loops[currentPosition] + 1;
            }
        }
        }

    static void InitLoops()
    {
        for(int i = 0; i < numberOfLoops; i++)
        {
            loops[i] = 1;
        }
    }
    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
    
    }



}
