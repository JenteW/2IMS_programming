using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Module_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                input = input.Trim();
                string[] unsortedNames = File.ReadAllLines("names.txt");
                List<string> list = new List<string>();
                list = unsortedNames.ToList();
                Assignment assignment = new Assignment();

                List<string> sortedNames = assignment.Solve(list);

                string[] names = sortedNames.ToArray();

                Console.WriteLine(assignment.BinarySearch(names, input));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}