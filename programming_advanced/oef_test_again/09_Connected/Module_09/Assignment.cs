using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_09
{
    /*Check if a weighted graph is connected or not. A graph is considered connected if there is a path between every pair of nodes.
            Input
            5 --> nr of nodes
            3 --> nr of edges
            0,1,8 --> node 1, node 2, weight
            2,3,6
            3,4,9
            output
            not connected
            explanation
            There is no connection between 1 and 2
            Input
            3 --> nr of nodes
            2 --> nr of edges
            0,1,8
            1,2,9
            output
            connected
            explanation
            All nodes are connected, we can travel from node 0 to node 2*/
    internal class Assignment
    {
        private int nodes;
        List<int>[] graph;
        public int startnode;
        private int edges;       

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
            this.startnode = -1;
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
                graph[source].Add(destination);
                if (startnode == -1)
                {
                    startnode = source;
                }

            }
        }
        public string DFS(int startnode, List<int> visited = null)
        {
            if(nodes - edges != 1)
            {
                return "not connected";
            }
            if (startnode < 0)
            {
                return "Crazy input!";
            }
            if (visited == null) visited = new List<int>();

            visited.Add(startnode);
            
            foreach (var node in graph[startnode])
            {
                if (!visited.Contains(node))
                {
                    DFS(node, visited);
                    
                }
                if (visited.Count == nodes)
                {
                    return "connected";
                }
            }

            return "not connected";
        }
    }
}
