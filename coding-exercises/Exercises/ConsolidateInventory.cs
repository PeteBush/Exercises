using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {

        /*
      * Given two Dictionarys, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2, 
      * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
      * 
      * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
      *  
      * consolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
      * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
      * 
      */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {


            foreach (KeyValuePair<string, int> kvp in dict1)
            {
                if(dict2.ContainsKey(kvp.Key))
                {
                    dict2[kvp.Key] += kvp.Value;
                }
                else
                {
                    dict2[kvp.Key] = kvp.Value;
                }
            }
            return dict2;
        }
    }
}
