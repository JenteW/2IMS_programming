using System;

namespace Module_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string filename = "words.txt";
            Assignment assignment = new Assignment();

            Console.WriteLine(assignment.NthCharacter(number, filename));
        }
    }
}