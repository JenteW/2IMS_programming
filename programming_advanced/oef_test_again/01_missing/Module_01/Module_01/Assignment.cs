using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    internal class Assignment
    {
        public int Missing(int[] array)
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
