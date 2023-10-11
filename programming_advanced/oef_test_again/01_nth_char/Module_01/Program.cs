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
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
            string filename = "words.txt";
            Assignment assignment = new Assignment();

                Console.WriteLine(assignment.NthCharacter(number, filename));

            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}