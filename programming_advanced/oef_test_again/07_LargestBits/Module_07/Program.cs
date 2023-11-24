using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                int input = int.Parse(Console.ReadLine());
                int solution = assignment.LargestBinary(input);
                Console.WriteLine(solution);
            }
            catch 
            {
                Console.WriteLine("Crazy input!");       
            }
        }
    }
}