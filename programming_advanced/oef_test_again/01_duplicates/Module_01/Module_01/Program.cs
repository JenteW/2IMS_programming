using System.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment assignment = new Assignment();
            string filename = "words.txt"; //Console.ReadLine();
            string start = Console.ReadLine();
            Console.WriteLine(assignment.Duplicates(start, filename));

        }
    }
}