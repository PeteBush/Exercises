using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Palindrome
    {
        public int palindromeChainLength(int n)
        {
            string nString = n.ToString();
            char[] charArray = nString.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
       
            int count = 0;
            while (nString != reverseString)
            {
                count++;

                long sum = long.Parse(nString) + long.Parse(reverseString);

                nString = sum.ToString();
                charArray = nString.ToCharArray();
                Array.Reverse(charArray);
                reverseString = new string(charArray);               
            }
            return count;
        }
    }
}
