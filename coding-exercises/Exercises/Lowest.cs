using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Lowest
    {
        public int FindLowestInt(int[] args)
        {
            int smallestInt = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                if(args[i] < smallestInt)
                {
                    smallestInt = args[i];
                }
            }
            return smallestInt;
        }
    }
}
