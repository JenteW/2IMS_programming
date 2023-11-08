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
            try
            {
                string input = Console.ReadLine();
                string input2 = input;

                Assignment assignment = new Assignment();
                string[] words = assignment.words();

                assignment.Backtrack(input, input2);
                assignment.SearchWords(words);
                Console.WriteLine(assignment.ToString());
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}