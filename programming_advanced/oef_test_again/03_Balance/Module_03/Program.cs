using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment assignment = new Assignment();
            string input = Console.ReadLine();
            Console.WriteLine(assignment.Balance(input));
            

        }
    }
}