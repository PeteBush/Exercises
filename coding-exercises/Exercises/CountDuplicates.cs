using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class CountDuplicates
    {
        public int Count(string input)
        {
            int count = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(char character in input)
            {
                if(dict.ContainsKey(character.ToString().ToLower()))
                {
                    dict[character.ToString().ToLower()] += 1;

                }
                else
                {
                    dict[character.ToString().ToLower()] = 1;
                }
            }

            foreach(KeyValuePair<string, int> kvp in dict)
            {
                if(kvp.Value > 1)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
