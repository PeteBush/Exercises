using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class RemoveNoise
    {
        public string RemovNoise(string input)
        {
            string returnString = "";
           
            foreach(char letter in input)
            {
                if(letter != '%' && letter != '$' && letter != '&' && letter != '/' && letter != '#' && letter != '·' && letter != '@' && letter != '|' && letter != 'º' && letter != '\\' && letter != 'ª')
                {
                    returnString += letter;
                }

            }

            return returnString;
        }
    }
}
