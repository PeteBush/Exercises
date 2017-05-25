using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class PaulCipher
    {
        public string Encode(string input)
        {
            if(input == "")
            {
                return "";
            }
            string returnString = input[0].ToString();

            int prevLetterPosition = 0;

            Dictionary<char, int> alphaPosition = new Dictionary<char, int>()
            {
                {'A', 1 },
                {'B', 2 },
                {'C', 3 },
                {'D', 4 },
                {'E', 5 },
                {'F', 6 },
                {'G', 7 },
                {'H', 8 },
                {'I', 9 },
                {'J', 10 },
                {'K', 11 },
                {'L', 12 },
                {'M', 13 },
                {'N', 14 },
                {'O', 15 },
                {'P', 16 },
                {'Q', 17 },
                {'R', 18 },
                {'S', 19 },
                {'T', 20 },
                {'U', 21 },
                {'V', 22 },
                {'W', 23 },
                {'X', 24 },
                {'Y', 25 },
                {'Z', 26 }
            };


            for (int i = 0; i < input.Length; i++)
            {
                int currentLetterPosition = 0;
                string let = input[i].ToString().ToUpper();
                char[] letters = let.ToCharArray();
                char letter = let[0];

                if (!alphaPosition.ContainsKey(letter))
                {
                    returnString += letter;
                    continue;
                }
                foreach (KeyValuePair<char, int> kvp in alphaPosition)
                {
                    if (kvp.Key == letter)
                    {
                        currentLetterPosition = kvp.Value;
                    }
                }

                int encodedLetterIndex = currentLetterPosition + prevLetterPosition;

                if (encodedLetterIndex > 26)
                {
                    encodedLetterIndex -= 26;
                }

                foreach (KeyValuePair<char, int> kvp in alphaPosition)
                {
                    if (kvp.Value == encodedLetterIndex && i > 0)
                    {
                        returnString += kvp.Key;
                    }
                }


                foreach (KeyValuePair<char, int> kvp in alphaPosition)
                {
                    if (kvp.Key == letter)
                    {
                        prevLetterPosition = kvp.Value;
                    }


                }

            }

            return returnString;

        }
        public string Decode(string input)
        {

            if(input == "")
            {
                return "";
            }
            Dictionary<char, int> alphaPosition = new Dictionary<char, int>()
            {
                {'A', 1 },
                {'B', 2 },
                {'C', 3 },
                {'D', 4 },
                {'E', 5 },
                {'F', 6 },
                {'G', 7 },
                {'H', 8 },
                {'I', 9 },
                {'J', 10 },
                {'K', 11 },
                {'L', 12 },
                {'M', 13 },
                {'N', 14 },
                {'O', 15 },
                {'P', 16 },
                {'Q', 17 },
                {'R', 18 },
                {'S', 19 },
                {'T', 20 },
                {'U', 21 },
                {'V', 22 },
                {'W', 23 },
                {'X', 24 },
                {'Y', 25 },
                {'Z', 26 }
            };
            input = input.ToUpper();
            string returnString = input[0].ToString();
            int previousLetterIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentLetterIndex = 0;
                char[] letters = input[i].ToString().ToCharArray();
                char letter = letters[0];

                if (!alphaPosition.ContainsKey(letter) && i > 0)
                {
                    returnString += letter;
                    continue;
                }

                foreach(KeyValuePair<char, int> kvp in alphaPosition)
                {

                    if(kvp.Key == letter)
                    {
                        currentLetterIndex = kvp.Value;
                    }
                }

                int index = currentLetterIndex - previousLetterIndex;

                if(index <= 0)
                {
                    index += 26;
                }

                foreach(KeyValuePair<char, int> kvp in alphaPosition)
                {

                    if(kvp.Value == index && i > 0)
                    {
                        returnString += kvp.Key;
                    }
                }

                previousLetterIndex = index;

            }

            return returnString;

        }
    }


}



