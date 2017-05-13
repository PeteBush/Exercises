using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class RemoveRepeating
    {
        public string Remove(string input)
        {
            char checker = input[0];
            string returnString = "";
            for (int i = 1; i < input.Length; i++)
            {
                
                if(checker == input[i])
                {
                   continue;
                }
                
                returnString += checker;
                checker = input[i];
                
            }
            returnString += checker;
            return returnString;
        }
    }
}
