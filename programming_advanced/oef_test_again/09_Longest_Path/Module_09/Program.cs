using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09
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
                Console.WriteLine(assignment.LongestRoute(assignment.startnode));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}