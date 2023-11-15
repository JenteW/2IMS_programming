using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_06
{
    internal class Assignment
    {
        public List<int> Solve(List<int> list)
        {

            if (list.Count <= 1)
            {
                return list;
            }
            int pivot = list[0];
            List<int> lower = new List<int>();
            List<int> higher = new List<int>();

            foreach (var item in list)
            {
                if (item < pivot)
                {
                    lower.Add(item);
                }
                else if (item > pivot)
                {
                    higher.Add(item);
                }
            }
            return Solve(lower).Union(new List<int>() { pivot }).Union(Solve(higher)).ToList();
        }

        public int MissingLink(List<int> list)
        {
            List<int> sortedList = Solve(list);
            int number = sortedList[0];
            int result = -1;
            bool pos = false;
            foreach (var item in sortedList)
            {
                if (item > 0)
                {
                    pos = true;
                }
                if (pos)
                {
                    number = item;
                    break;
                }
            }
            foreach (var item in sortedList)
            {
                if (item > 0)
                {
                    if (item != number && number > 0)
                    {
                    result = number;
                    break;
                    }
                
                    number++;
                }
            }
            return result;
        }
    }
}
