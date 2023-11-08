using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine().ToLower();
                string input2 = input;
                  
                Assignment assignment = new Assignment();
                string[] words = assignment.words();

                assignment.Backtrack(input, input2);
                assignment.SearchWords(words);
                Console.WriteLine(assignment.ToString().Trim());
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}