using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Survivor
    {
        public int JosSurvivor(int n, int k)
        {
            List<int> survivorList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                survivorList.Add(i + 1);
            }
            int index = k;
            while (survivorList.Count > 1)
            {
                while (index > survivorList.Count)
                {
                    index -= survivorList.Count;
                }
                survivorList.RemoveAt(index - 1);
                index += (k - 1);


            }

            return survivorList[0];
        }

    }
}
