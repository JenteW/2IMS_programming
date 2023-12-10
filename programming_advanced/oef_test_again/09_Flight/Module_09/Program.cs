using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace Module_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = int.Parse(Console.ReadLine());
                int edges = int.Parse(Console.ReadLine());
                Assignment assignment = new Assignment(nodes);
                assignment.AddEdge(edges);
                int start= assignment.GetCity(Console.ReadLine());
                assignment.setStartNode(start);
                int end = assignment.GetCity(Console.ReadLine());
                assignment.setEndNode(end);
                int answer = assignment.Dijkstra(assignment.startnode);
                if (answer == int.MaxValue || answer== -1)
                {
                    Console.WriteLine("Crazy input!");
                }
                else
                {
                    Console.WriteLine(answer);
                }

            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}