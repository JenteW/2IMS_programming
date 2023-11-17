using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Maze
    {
        private int nodes;
        List<int>[] graph;
        List<int> visited = new List<int>();

        public Maze(int nodes) 
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
        }
        public void AddEdge(int node1, int node2)
        {
            graph[node1].Add(node2);
            graph[node2].Add(node1);
            
        }

/*        public List<int> DFS(int start, int goal)
        {
            visited.Add(start);
            if (start == goal)
            {
                Console.WriteLine("Goal found!");
                return visited;

            }
            foreach (int node in graph[start])
            {
                
                if (!visited.Contains(node))
                {
                    DFS(node, goal);

                }
            }
            return visited;
            
        }*/


        public string DFS(int startnode, List<int> visited = null)
        {
            if(visited == null)
            {
                visited = new List<int>();
            }

            visited.Add(startnode);

            foreach (int node in graph[startnode])
            {
                if (!visited.Contains(node))
                {
                    DFS(node, visited);
                }
            }
            return String.Join(" ", visited);
        }


        public string DFS_stack(int startnode)
        {
            Stack<int> stack = new Stack<int>();
            List<int> visited = new List<int>();

            stack.Push(startnode);

            while(stack.Count > 0)
            {
                int node = stack.Pop();
                visited.Add(node);
                if(node == 0)
                {
                    return String.Join(" ", visited);

                }

                foreach (var nextNode in graph[node])
                {
                    if (!visited.Contains(nextNode))
                    {
                        stack.Push(nextNode);
                    }
                }
               
            }
            return String.Join(" ", visited);

        }



        public string BFS(int startnode)
        {
            Queue<int> queue = new Queue<int>();
            List<int> visited = new List<int>();

            queue.Enqueue(startnode);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

                if (!visited.Contains(node))
                {
                    visited.Add(node);
                }

                if (node == 0)
                {
                    return String.Join(" ", visited);

                }

                foreach (var nextNode in graph[node])
                {
                    if (!visited.Contains(nextNode))
                    {
                        queue.Enqueue(nextNode);
                    }
                }

            }
            return String.Join(" ", visited);

        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nodes; i++)
            {
                s += $"{i} --->" + String.Join(" ", graph[i]) + "\n";
            }
            return s;
        }
    }
}
