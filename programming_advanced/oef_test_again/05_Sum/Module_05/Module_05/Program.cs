using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            Assignment assignment = new Assignment();
            string input = Console.ReadLine();
            int number = int.Parse(input);
            assignment.Sum(number, new List<int>(), 1);
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}