using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            Assignment assignment = new Assignment();
            string input = Console.ReadLine();
            assignment.createTree(input);
            Console.WriteLine(assignment.Balanced(assignment.Root));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}