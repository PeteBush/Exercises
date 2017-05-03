using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class SecHighest
    {
        /*
 * CHALLENGE: Given an array of integers, return the second highest number.
 * For arrays of length 0 retun 0, length 1 return the highest number.
 * 
 * SecondHighest([]) -> 0
 * SecondHighest([1]) -> 1
 * SecondHighest([1, 3, 5]) -> 3
 * SecondHighest([1, 3, 3]) -> 3
 * SecondHighest([1, 4, 6, 8, 23, 13]) -> 13
 */
        public int SecondHighest(int[] nums)
        {
            int highest = 0;
            int secondHighest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= highest)
                {
                    secondHighest = highest;
                    highest = nums[i];                     
                }
                if(nums[i] < highest && nums[i] > secondHighest)
                {
                    secondHighest = nums[i];
                }

            }
            if(nums.Length == 1)
            {
                return highest;
            }
            return secondHighest;
        }
    }
}
