using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    public class Assignment
    {
        public string Missing(int[] array)
        {
            /*for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[0] + i)
                {
                    return (array[i] - 1).ToString();
                }
            }
            return "-1";*/


            int left = 0;
            int right = array.Length - 1;
            int mid;
            while (left <= right)
            {
                 mid = left + (right - left) / 2;

                if (array[mid] == mid + 1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (left < array.Length && array[left] != left + 1)
            {
                return (left + 1).ToString();
            }

            return "No missing number.";
        }
    }
}
