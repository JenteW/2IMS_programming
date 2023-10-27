using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {

        /*Read in a string and remove all the same adjacent characters.

                Catch: you are not allowed to use loops or LINQ statements!

 

                Input/Output
                input:
                aabbccdde eff
                output:
                abcde ef

                input:
                abcdefg
                output:
                abcdefg

 

                CodeGrade Setup = .Net framework 6.0

                Code instructions

                To solve this assignment you need to create a Module_04 namespace with an Assignment-class and a method Unique

                namespace Module_03
                {
                  public class Assignment
                  {
                    public ... Unique(...)
                    {}
                  }
                }*/
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                Console.WriteLine(assignment.Unique(input));

            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}