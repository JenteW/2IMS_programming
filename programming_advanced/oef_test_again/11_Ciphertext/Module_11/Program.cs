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
            try
            {
                Assignment assignment = new Assignment();
                string[] text = assignment.GetFile("english.txt");
                string input = Console.ReadLine().ToLower().Trim();
                List<int> ascii = assignment.GetASCII(input);
                Console.WriteLine(assignment.Check(ascii, text));
            }
            catch
            {
                  Console.WriteLine("Crazy input");
            }
        }
    }
}