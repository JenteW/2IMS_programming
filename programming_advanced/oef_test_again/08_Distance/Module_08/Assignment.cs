using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_08
{
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

        public void AddEdge(int node1, int node2)
        {
            graph[node1].Add(node2);
            graph[node2].Add(node1);

        }

        public int[] BFS(int startnode)
        {
            Queue<int> queue = new Queue<int>();
            List<int> visited = new List<int>();
            int[] distance = new int[nodes];
            for(int i = 0; i < nodes; i++)
            {
                distance[i] = -1;
            }


            queue.Enqueue(startnode);
            distance[startnode] = 0;

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

               /* if (!visited.Contains(node))
                {
                    visited.Add(node);
                }

                if (node == 0)
                {
                    return distance;

                }*/

                foreach (var nextNode in graph[node])
                {
                    if (distance[nextNode] == -1)
                    {
                        distance[nextNode] = distance[node] + 1;
                        queue.Enqueue(nextNode);
                    }
                    /*if (!visited.Contains(nextNode))
                    {
                        queue.Enqueue(nextNode);
                    }*/
                }

            }
            return distance;

        }
    }
}
