using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {

        /*Multiply two numbers without using the '*' operator, utilizing recursion.

            Catch: you are not allowed to use loops or LINQ statements!


            Input/Output
            input:
            567 12
            output:
            6804

            input:
            -11 100
            output:
            -1100

            CodeGrade Setup = .Net framework 6.0

            Code instructions

            To solve this assignment you need to create a Module_04 namespace with an Assignment-class and a method Multiplication

            namespace Module_03
            {
              public class Assignment
              {
                public ... Multiplication(...)
                {}
              }
            }*/
        static void Main(string[] args)
        {

            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                string[] split = input.Split(' ');
                int number = Convert.ToInt32(split[0]);
                int times = Convert.ToInt32(split[1]);

                Console.WriteLine(assignment.Multiplication(number, times));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }



        }
    }
}