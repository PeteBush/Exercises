using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class HighAndLow
    {
        public string HighLow(string numbers)
        {
            string[] nums = numbers.Split(' ');


            int highest = int.Parse(nums[0]);
            int lowest = int.Parse(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                int num = int.Parse(nums[i]);
                if (num > highest)
                {
                    highest = num;
                }
                if (num < lowest)
                {
                    lowest = num;
                }
            }
            return (highest.ToString() + " " + lowest.ToString());
        }
    }
}
