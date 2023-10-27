using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {
        /*Find the occurrence of a number (first line of input) in a sequence of numbers (second line of input)

            Catch: you are not allowed to use loops or LINQ statements!


            Input/Output
            input:
            8
            7 8 5 4 1 2 8 8 9 6 5 4 8
            output:
            4

            input:
            0
            0 0 0 0 4 5 8 7 4 0 0
            output:
            6

 

            CodeGrade Setup = .Net framework 6.0

            Code instructions

            To solve this assignment you need to create a Module_04 namespace with an Assignment-class and a method Occurences

            namespace Module_03
            {
              public class Assignment
              {
                public ... Occurences(...)
                {}
              }
            }*/
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                char num = Convert.ToChar(input);
                string line = Console.ReadLine();

                Console.WriteLine(assignment.Occurence(num, line));

            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}