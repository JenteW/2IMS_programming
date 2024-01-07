using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_exam
{
    internal class BruteForce
    {
        public int Brute(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] != array[j])
                    {
                        int temp = (array[i]*10) + array[j];
                        int check = Convert.ToInt32(temp);
                        if (check > max)
                        {
                            max = check;
                        }
                    }
                }
            }
            return max;
        }
    }
}
