using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_missing
{
    internal class Sorting
    {
        public int Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[0] + i)
                {
                    return array[i] - 1;
                }
            }
            return -1;
        }
    }
}
