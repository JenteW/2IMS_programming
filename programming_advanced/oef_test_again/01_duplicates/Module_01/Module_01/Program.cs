using System.Diagnostics.Tracing;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment assignment = new Assignment();
            string filename = "words.txt"; //Console.ReadLine();
            string start = "aa"; //Console.ReadLine();
            Console.WriteLine(assignment.Duplicates(start, filename));

        }
    }
}