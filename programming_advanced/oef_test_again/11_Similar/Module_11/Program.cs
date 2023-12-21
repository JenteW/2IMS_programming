using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                Console.WriteLine(assignment.Similar(s1, s2));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}