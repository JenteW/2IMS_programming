using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
                if(input <1)
                {
                    throw new Exception();
                }
                int total = assignment.Sum(input);
                Console.WriteLine(assignment.ToString().Trim());
                Console.WriteLine(total);
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}