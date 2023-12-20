using System;
namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine().Trim();
                int[] ints = Array.ConvertAll(input.Split(' '), int.Parse);
                foreach (int i in ints)
                {
                    assignment.Add(i);
                }
                Console.WriteLine(assignment.BFS());
            }
            catch 
            {
                Console.WriteLine("Crazy input!");
            }
            
        }
    }
}