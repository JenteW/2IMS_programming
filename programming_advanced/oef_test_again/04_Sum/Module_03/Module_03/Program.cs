namespace Module_03
{
    internal class Program
    {

        /*read in a word and add up all the digits

            Catch: you are not allowed to use loops or LINQ statements!

 

            Input/Output
            input:
            123456789 are all digits
            output:
            45

            input:
            There are no digits
            output:
            0

 

            CodeGrade Setup = .Net framework 6.0

            Code instructions

            To solve this assignment you need to create a Module_04 namespace with an Assignment-class and a method Sum

            namespace Module_03
            {
              public class Assignment
              {
                public ... Sum(...)
                {}
              }
            }*/
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment();
            string input = Console.ReadLine();
            Console.WriteLine(assignment.Sum(input));
        }
    }
}