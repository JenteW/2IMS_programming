using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Maze
    {
        private int nodes;
        //Dictionary<int, int>[] graph;
        List<int>[] graph;
        //Dictionary<int, List<int>> maze;
        public Maze(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];
            for(int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
          /*  graph = new Dictionary<int, int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new Dictionary<int, int>();
            }*/
        }

        public void AddEdge(int node1, int node2)
        {
            /*graph[node1].Add(node2, Math.Abs(node1 - node2));
            graph[node2].Add(node1, Math.Abs(node2 - node1));*/
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }

        //start at node 12

        public void Dijkstra(int startnode)
        {
            List<int> visited = new List<int>();
            int[] distances = new int[nodes];
            int[] previous  = new int[nodes];
            for (int i = 0;i < nodes;i++)
            {
                distances[i] = Int32.MaxValue;
            }
            distances[startnode] = 0;

            while (true)
            {
                int node = GetNextNode(distances, visited);
                if (node == -1) break;
                if (node == 0) break;
                visited.Add(node);
                foreach(var neighbour in graph[node])
                {
                    int cost = distances[node] + Math.Abs(node-neighbour);
                    if(cost < distances[neighbour])
                    {
                        distances[neighbour] = cost;
                        previous[neighbour] = node;
                    }
                }
            }
            for(int i = 0; i < nodes; i++)
            {
                Console.WriteLine("kost om aan " + i + " te geraken is " + distances[i] + " via " + previous[i]);
            }
            int end = 0;
            string path = "";
            while(end != startnode)
            {
                //path = end + " " + path;
                path = path + " " + end;
                end = previous[end];
            }
            Console.WriteLine("pad is " + path);
        }

        private int GetNextNode(int[] distances, List<int> visited)
        {
            int node = -1;
            int min = Int32.MaxValue;
            for(int i = 0; i < nodes;i++)
            {
                if(distances[i] < min && !visited.Contains(i))
                {
                    node = i;
                    min = distances[i];
                }
            }
            return node;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nodes; i++)
            {
                s += i + " --> " + String.Join(" ", graph[i]) + "\n";
            }
            return s;
        }



        
    }
}
