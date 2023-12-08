using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_09
{
    internal class Assignment
    {
        private int nodes;
        private int edges;
        private List<(int, int)>[] graph;
        public int startnode = -1;

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph = new List<(int, int)>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<(int, int)>();
            }
        }

        public void AddEdge(int edges)
        {
            this.edges = edges;
            for (int i = 0; i < edges; i++)
            {

                string input = Console.ReadLine();
                string[] inputArray = input.Split(',');
                int source = Convert.ToInt32(inputArray[0]);
                int destination = Convert.ToInt32(inputArray[1]);
                int weight = Convert.ToInt32(inputArray[2]);
                graph[source].Add((destination, weight));
                if (startnode == -1)
                {
                    startnode = source;
                }

            }
        }

        public int LongestRoute(int startnode)
        {
            int longest = 0;

            foreach (var item in graph[startnode])
            {
                int temp = Math.Abs(item.Item2) + Math.Abs(LongestRoute(item.Item1));
                if (temp > longest)
                {
                    longest = temp;
                }
            }
            return longest;
        }
    }
}
