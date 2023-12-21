using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_11
{
    internal class Assignment
    {
        public string MissingNumber(List<int> nums, int n )
        {
            nums.Sort();
            string missing = "";
            if (nums.Count == 0)
            {
                return "No missing integers!";
            }
           
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i + 1] != nums[i] + 1)
                {
                    missing += (nums[i] + 1) + " ";
                }
            }
            if(missing.Length == 0)
            {
                return "No missing integers!";
            }
            if (!nums.Contains(n))
            {
                missing += n;
            }
            return missing;
        }
    }
}
