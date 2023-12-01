using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08
{
    /*Implement a Depth-First Search (DFS) algorithm to determine the number of connected components in a graph.

        Input/Output
        Input
        5 --> nr of nodes
        3 --> nr of edges
        0 1
        2 3
        3 4
        output
        2
        explanation
        There are two connected components in this graph: one containing nodes 0 and 1, and the other containing nodes 2, 3, and 4.

        Input
        4 --> nr of nodes
        1 --> nr of edges
        0 2
        output
        3
        explanation
        There are three connected components in this graph: one containing nodes 0 and 2, and two single-node components containing nodes 1 and 3.*/
    internal class Assignment
    {
        private int nodes;
        List<int>[] graph;
        List<int> visited = new List<int>();

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
            visited = new List<int>();
        }

        public void AddEdge(int edges)
        {
            for(int i = 0; i < edges; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                graph[a].Add(b);
                graph[b].Add(a);

            }
        }
        public void DFS(int node)
        {
            if (!visited.Contains(node))
            {
                visited.Add(node);
                foreach (var item in graph[node])
                {
                    DFS(item);
                }
            }
        }

        public int Count()
        {
            int count = 0;
            for(int i = 0; i < nodes; i++)
            {
                if (!visited.Contains(i))
                {
                    DFS(i);
                    count++;
                }
            }
            return count;
        }
    }
}
