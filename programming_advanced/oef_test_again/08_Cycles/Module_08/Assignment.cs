using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Module_08
{
    internal class Assignment
    {
        private int nodes;
        List<int>[] graph;
        public int startnode = -1;

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
        }


        public void AddEdge(int edges)
        {
            for (int i = 0; i < edges; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                int source = Convert.ToInt32(inputArray[0]);
                int destination = Convert.ToInt32(inputArray[1]);
                graph[source].Add(destination);
                if(startnode == -1)
                {
                    startnode = source;
                }

            }
        }

        public string DFS(int startnode, int goal, List<int> visited = null)
        {
            if(startnode == -1)
            {
                return "Crazy input!";
            }
            if (visited == null) visited = new List<int>();

            visited.Add(startnode);
            visited.Add(-1);

            foreach (var node in graph[startnode])
            {
                if (!visited.Contains(node))
                {
                    DFS(node, goal, visited);
                }
                else if (visited.Contains(node) && visited.LastIndexOf(node) == visited.Count - 2)
                {
                    return "cyclic";
                }
            }
            visited.RemoveAt(visited.Count - 1);

            return "acyclic";
        }
       


    }
}
