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
                Assignment assignment = new Assignment();

                string input = Console.ReadLine().ToLower();
                if(input.Length < 2)
                {
                    throw new Exception();
                }
                List<string> subwords = assignment.GetWords(input);
                List<string> validWords = assignment.IsValid(subwords);

                Console.WriteLine(string.Join(" ", validWords));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}