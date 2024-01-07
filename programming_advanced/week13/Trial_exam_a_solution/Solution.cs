using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_exam_a_solution
{
    internal class Solution
    {
        public int[] Nrs { get; set; }

        public Solution(int[] nrs)
        { 
            Nrs = nrs;
        
        }

        public int BruteForce()
        {
            int max = Int32.MinValue;                // space O(1)
            List<int> list = new List<int>();       //space comp O(n^2)
            for (int i = 0; i < Nrs.Length; i++) // time O(n^2)
            {
                for(int j = 0; j < Nrs.Length; j++)
                {
                    if(i != j) // niet 2 keer hetzelfde getal gebruiken (getal op dezelfde positie)
                    {
                        int current = Convert.ToInt32(Nrs[i].ToString() + Nrs[j].ToString());
                        if (current > max) max = current;
                        list.Add(current);
                    }
                }
            }
            return max;
            //return nrs.Max(); // O(n)
        
        }

        public int Greedy()     // plaats O(1)
        {
            Array.Sort(Nrs); // is merge of quicksort --> O(n log n)
            Array.Reverse(Nrs); // O(n)
            return Convert.ToInt32(String.Join("", Nrs[0], Nrs[1]));
        }

        public int Linear()
        {
            int max = Int32.MinValue;
            int semax = Int32.MinValue;

/*            for (int i = 0;i < Nrs.Length;i++)
            {
                if(max < Nrs[i]) max = Nrs[i];
                if(Nrs[i] != max && semax < Nrs[i]) semax = Nrs[i];
            }*/
            for (int i = 0; i < Nrs.Length; i++) // time O(n) place O(1)
            {
                if (max < Nrs[i])
                {
                    if (semax < max)
                    {
                        semax = max;
                    }
                max = Nrs[i];

                }
            if (Nrs[i] != max && semax < Nrs[i]) semax = Nrs[i];
            }
            return Convert.ToInt32(String.Join("", max, semax));
        }
    }
}
