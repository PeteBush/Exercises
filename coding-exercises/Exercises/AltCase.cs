using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class AltCase
    {
        public string ToAlternatingCase (string s)
        {

            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].ToString().ToUpper() == s[i].ToString())
                {
                    newString += s[i].ToString().ToLower();
                }
                else
                {
                    newString += s[i].ToString().ToUpper();
                }

            }
            return newString;
 

        }
    }
}
