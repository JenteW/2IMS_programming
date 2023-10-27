using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    internal class Program
    {

        /*Find the minimum element in a given array.

        Catch: you are not allowed to use loops or LINQ statements!

        Input/Output
        input:
        1 2 5 4 7 8 1
        output:
        1

        input:
        5 6 9 8 7 4 10 0 2 -4 5 7
        output:
        -4

        Code instructions

        To solve this assignment you need to create a Module_04 namespace with an Assignment-class and a method Minimum

        namespace Module_04
        {
          public class Assignment
          {
            public ... Minimum(...)
            {}
          }
        }
        The following content is*/
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                string[] split = input.Split(' ');
                int min = int.Parse(split[0]);

                Console.WriteLine(assignment.Minimum(split, min));

            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}