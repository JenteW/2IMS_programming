using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nQueen
{
    internal class Subset
    {
        public List<List<int>> Solve(int[] ints)
        {
            List<List<int>> results = new List<List<int>>();

            List<int> list = new List<int>();

            CreateSubset(ints, 0, results, list);
            
            return results;
        }

        private void CreateSubset(int[] array, int index, List<List<int>> results, List<int> subset)
        {
            results.Add(new List<int>(subset));

            for(int i = index; i < array.Length; i++)
            {
                subset.Add(array[i]);
                CreateSubset(array, i + 1, results, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }
        public List<List<int>> SolveBinary(int[] ints)
        {
            /*int n = ints.Length;
            for(int i = 0; i < (1 << n); i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if((i & (1 << j)) > 0)
                    {
                        Console.Write(ints[j] + " ");
                    }
                }
                Console.WriteLine();
            }*/
            List<List<int>> results = new List<List<int>>();
            int count = (int) Math.Pow(2, ints.Length);
            for(int i = 0; i < count; i++)
            {
                List<int> list = new List<int>();

                string binary = Convert.ToString(i, 2).PadLeft(ints.Length, '0');
                for(int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        list.Add(ints[j]);
                    }
                }
                results.Add(list);
            }
            return results;
        }

    }
}
