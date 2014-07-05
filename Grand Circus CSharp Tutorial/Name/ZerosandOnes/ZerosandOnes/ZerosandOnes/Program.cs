using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerosandOnes
{
    class Program
    {
        //luminosity
        static void Main(string[] args)
        {
            int[,] board = new int[3, 3];
            board[1,1]=1;
            board[0, 1] = 1;
            board[1, 0] = 1;
            for (int x = 0; x <2; x++)
            {
                Console.Write(board[x, 0] + " " );
                Console.Write(board[0, x] + " ");
            }
            Console.ReadKey();
            
        }
   
    
    }
       
}
