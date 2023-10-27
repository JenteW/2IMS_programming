using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace devide_and_conquer
{
    internal class Sum
    {

        public int SolveIterative(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }
        public int SolveRecusive(int[] array, int index = 0)
        {
            if (array.Length == index)
            {
                return 0;
            }
            return array[index] + SolveRecusive(array, ++index);
        }

 /*       public int SolveRecusive(int[] array)
        {
            if(array.Length == 1) { 
               
                return array[0];
            
            }

            return array[0] + SolveRecusive(array.Skip(1).ToArray());
        }*/

        public int ListRecursive(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }
            if (list.Count == 1)
            {
                return list[0];
            }

            return list[0] + ListRecursive(list.Skip(1).ToList());
        }
    }
}
