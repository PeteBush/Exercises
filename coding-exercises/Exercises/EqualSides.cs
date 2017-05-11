using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class EqualSides
    {
        public int EqualSidesOfAnArray(int[] nums)
        {
            int rightSide = 0;
            int leftSide = 0;
            int index = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                leftSide += nums[i -1];
                index = i;
                for (int j = index; j < nums.Length -1; j++)
                {
                    rightSide += nums[j +1];
                }
                if(rightSide == leftSide)
                {
                    break;
                }
                rightSide = 0; 
            }

            if(index == nums.Length-1)
            {
                return -1;
            }
            return index;

        }
    }
}
