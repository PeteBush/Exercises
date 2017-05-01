using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class MostFrequentDigit
    {
        public int MostFrequentDigitSum(int n)
        {
            List<int> firstSequence = new List<int>();

            while (n > 0)
            {
                firstSequence.Add(n);
                string nString = n.ToString();
                int sum = 0;

                foreach (char digit in nString)
                {
                    sum += int.Parse(digit.ToString());
                }
                n -= sum;
            }
            firstSequence.Add(0);

            List<int> secondSequence = new List<int>();
            foreach (int number in firstSequence)
            {
                string nString = number.ToString();
                int sum = 0;
                foreach (char digit in nString)
                {
                    sum += int.Parse(digit.ToString());
                }
                secondSequence.Add(sum);
            }
 
            secondSequence = secondSequence.OrderByDescending(x => x).ToList();
            Dictionary<int, int> countDict = new Dictionary<int, int>();
            foreach (int num in secondSequence)
            {
                if (countDict.ContainsKey(num))
                {
                    countDict[num] += 1;
                }
                else
                {
                    countDict[num] = 1;
                }
            }
            int highestCount = 0;
            foreach (KeyValuePair<int, int> kvp in countDict)
            {
                if(kvp.Value > highestCount)
                {
                    highestCount = kvp.Value;
                }
            }

            foreach(KeyValuePair<int, int> kvp in countDict)
            {
                if(kvp.Value == highestCount)
                {
                    return kvp.Key;
                }
            }
            return -1;
        }
    }
}
