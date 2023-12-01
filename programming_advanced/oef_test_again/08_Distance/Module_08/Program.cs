using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            int nodes = Int32.Parse(Console.ReadLine()); 
            int edges = Int32.Parse(Console.ReadLine());
            Assignment assignment = new Assignment(nodes);
            for (int i = 0; i < edges; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                assignment.AddEdge(Int32.Parse(edge[0]), Int32.Parse(edge[1]));
            }
            int startnode = Int32.Parse(Console.ReadLine());
            int[] distance = assignment.BFS(startnode);
            for (int i = 0; i < distance.Length; i++)
            {
                Console.WriteLine(distance[i]);
            }
            }
            catch 
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}