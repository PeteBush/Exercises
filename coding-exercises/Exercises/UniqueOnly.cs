using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    //given an array of ints, return an array of ints with all duplicates removed.
    //[1,2,1,4,5,6,2] --> [1,2,4,5,6]
    //Sort in order from lowest to highest

    public class UniqueOnly
    {
        public int [] RemoveDuplicates(int[] nums)
        {
                  
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hash.Add(nums[i]);
            }

            int[] array = hash.ToArray();
            Array.Sort(array);
            return array;


        }
    }
}
