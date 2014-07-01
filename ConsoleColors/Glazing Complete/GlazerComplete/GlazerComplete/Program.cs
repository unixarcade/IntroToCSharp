using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerComplete
{
    class GlazerCalc
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string widthSTring, heightString;

            do
            {
                Console.Write("Give the width of the window between " + MIN_WIDTH + " and " + MAX_WIDTH + " :");
                widthSTring = Console.ReadLine();
                width = double.Parse(widthSTring);
            } while ((width < MIN_WIDTH) || (width > MAX_WIDTH));

            do {
                Console.Write ("Give the width of the window between " + MIN_HEIGHT + )
            }
        
        
        
        
        
        }
    }
}
