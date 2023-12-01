using System;
namespace Module_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = int.Parse(Console.ReadLine());
                Assignment assignment = new Assignment(nodes);
                int edges = int.Parse(Console.ReadLine());
                assignment.AddEdge(edges);
                Console.WriteLine(assignment.Count());
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}