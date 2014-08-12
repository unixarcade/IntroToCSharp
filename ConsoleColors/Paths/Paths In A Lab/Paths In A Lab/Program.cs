using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paths_In_A_Lab;

namespace Paths_In_A_Lab
{

    static void FindPath(int row, int col)
        {
            if((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                return;
            }

            if(lab[row, col] == 'e')
            {
                Console.WriteLine("Found the exit!");
            }

            if(lab[row, col] != ' ')
            {
                return;
            }
        }

        lab[row, col] = 's';

        FindPath(row, col - 1);
        FindPath(row - 1, col);
        FindPath(row, col + 1);
        FindPath(row + 1, col);

        lab[row, col] = ' ';
}


  
    class Program
    {
      
static char[,] lab =
        {
            {' ',' ',' ','*',' ',' ',' '},
            {'*','*',' ','*',' ','*',' '},
            {' ',' ',' ',' ',' ',' ',' '},
            {' ','*','*','*','*','*',' '},
            {' ',' ',' ',' ',' ',' ','e'},
        };
        
        static void Main(string[] args)
        {

    FindPath(0, 0);

        }
    }

