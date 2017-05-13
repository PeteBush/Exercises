using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    //given an array of ints, return an array of ints with all duplicates removed.
    //[1,2,1,4,5,6,2] --> [1,2,4,5,6]

    public class UniqueOnly
    {
        public int [] RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> returnList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }
            foreach(KeyValuePair<int, int> kvp in dict)
            {
                returnList.Add(kvp.Key);
            }
            return returnList.ToArray();


        }
    }
}
