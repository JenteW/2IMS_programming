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
                int nodes = Convert.ToInt32(Console.ReadLine());
                int edges = Convert.ToInt32(Console.ReadLine());
                Assignment assignment = new Assignment(nodes);
                assignment.AddEdge(edges);
                Console.WriteLine(assignment.DFS(assignment.startnode));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}