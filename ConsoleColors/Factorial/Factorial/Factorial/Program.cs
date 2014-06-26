using System;
// compile with: /target:library
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Factorial
    {
       // declares namespace 
        public static int Calc(int i)
        {
            return ((i <= 1) ? 1 : (i * Calc(i - 1)));
        }
    }
}
