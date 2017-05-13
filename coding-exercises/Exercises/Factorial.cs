using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Factorial
    {
        public int FindFactorial(int n)
        {
            if(n > 1)
            {
                return (n * (FindFactorial(n - 1)));
            }
            else
            {
                return 1;
            }
        }
    }
}
