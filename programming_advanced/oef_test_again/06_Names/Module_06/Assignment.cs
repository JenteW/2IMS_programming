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
        public List<string> Solve(List<string> list)
        {

            if (list.Count <= 1)
            {
                return list;
            }

            string pivot = list[0];
            List<string> lower = new List<string>();
            List<string> higher = new List<string>();

            foreach (var item in list.Skip(1)) // Skip the pivot element in the loop
            {
                if (string.Compare(item, pivot) < 0)
                {
                    lower.Add(item);
                }
                else if (string.Compare(item, pivot) > 0)
                {
                    higher.Add(item);
                }
            }

            return Solve(lower).Concat(new List<string>() { pivot }).Concat(Solve(higher)).ToList();
        }
        public int BinarySearch(string[] arr, string target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparisonResult = string.Compare(arr[mid], target, StringComparison.OrdinalIgnoreCase);

                if (comparisonResult == 0)
                {
                    return mid; // Found the target name
                }
                else if (comparisonResult < 0)
                {
                    low = mid + 1; // Search in the right half
                }
                else
                {
                    high = mid - 1; // Search in the left half
                }
            }

            return 0; // Name not found
        }
    }

}
