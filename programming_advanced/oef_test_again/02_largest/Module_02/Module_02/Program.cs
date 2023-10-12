using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Module_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment();

            string input = Console.ReadLine();

            Console.WriteLine(assignment.Largest(input));
        }
    }
}