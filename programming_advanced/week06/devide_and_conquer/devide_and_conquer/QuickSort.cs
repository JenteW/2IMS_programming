using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace devide_and_conquer
{
    internal class QuickSort
    {

        public List<int> Solve(List<int> list)
        {

            if(list.Count <= 1)
            {
                return list;
            }
            int pivot = list[0];
            List<int> lower = new List<int>();
            List<int> higher = new List<int>();

            foreach(var item in list)
            {
                if(item < pivot)
                {
                    lower.Add(item);
                }
                else if (item > pivot)
                {
                    higher.Add(item);
                }
            }
            return Solve(lower).Union(new List<int>() { pivot }).Union(Solve(higher)).ToList();
           /* if (list.Count <= 1)
            {
                return list;
            }
            int pivot = list[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            foreach (int item in list.Skip(1))
            {
                if (item < pivot)
                {
                    left.Add(item);
                }
                else
                {
                    right.Add(item);
                }
            }
            left = Solve(left);
            right = Solve(right);
            List<int> solution = new List<int>();
            
            foreach(var item in left)
            {
                solution.Add(item);
            }
            solution.Add(pivot);
            foreach (var item in right)
            {
                solution.Add(item);
            }

            return solution;*/


            //HANOI
            
        }


    }
}
