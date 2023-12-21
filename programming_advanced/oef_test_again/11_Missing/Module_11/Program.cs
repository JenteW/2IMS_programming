using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            Assignment assignment = new Assignment();
            string input = Console.ReadLine().Trim();
            string[] inputArray = input.Split(' ');
            List<int> nums = new List<int>();
            foreach (string s in inputArray)
            {
                nums.Add(int.Parse(s));
            }
            int n = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine(assignment.MissingNumber(nums, n));
             }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}