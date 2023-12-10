using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace Module_09
{
    internal class Assignment
    {
        private int nodes;
        private int edges;
        private List<(string, int)>[] graph;
        private List<(string, int)>[] cityList;
        public int startnode = -1;
        public int endnode = -1;

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph = new List<(string, int)>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<(string, int)>();
            }

            cityList = new List<(string, int)>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                cityList[i] = new List<(string, int)>();
            }
        }

        public void setStartNode(int startnode)
        {
            this.startnode = startnode;
        }

        public void setEndNode(int endnode)
        {
            this.endnode = endnode;
        }

        public void AddEdge(int edges)
        {
            this.edges = edges;
            for (int i = 0; i < edges; i++)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(',');
                string source = inputArray[0].Trim();
                string destination = inputArray[1].Trim();
                int weight = int.Parse(inputArray[2].Trim());

                AddCity(source);
                AddCity(destination);

                graph[GetCity(source)].Add((destination, weight));
            }
        }

        public void AddCity(string city)
        {
            int existingCityIndex = GetCity(city);
            if (existingCityIndex == -1)
            {
                cityList[cityList.Length - 1].Add((city, cityList[cityList.Length - 1].Count));
            }
        }

        public int GetCity(string city)
        {
            for (int i = 0; i < cityList.Length; i++)
            {
                var item = cityList[i];
                for (int j = 0; j < item.Count; j++)
                {
                    var tuple = item[j];
                    if (tuple.Item1 == city)
                    {
                        return tuple.Item2;
                    }
                }
            }
            return -1;
        }
        public int Dijkstra(int startnode)
        {
            List<int> visited = new List<int>();
            int[] distances = new int[nodes];
            int[] previous = new int[nodes];

            for (int i = 0; i < nodes; i++)
            {
                distances[i] = int.MaxValue;
            }

            distances[startnode] = 0;

            while (visited.Count < nodes)
            {
                int node = GetNextNode(distances, visited);

                if (node == -1)
                {
                    break;
                }

                visited.Add(node);

                foreach (var tuple in graph[node])
                {
                    string neighbour = tuple.Item1;
                    int weight = tuple.Item2;

                    int cost = distances[node] + weight;

                    if (cost < distances[GetCity(neighbour)])
                    {
                        distances[GetCity(neighbour)] = cost;
                        previous[GetCity(neighbour)] = node;
                    }
                }
            }

            if (endnode != -1)
            {
                int total = distances[endnode];
                return total;
            }

            return -1;

        }
        private int GetNextNode(int[] distances, List<int> visited)
        {
            int node = -1;
            int min = Int32.MaxValue;
            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] < min && !visited.Contains(i))
                {
                    node = i;
                    min = distances[i];
                }
            }
            return node;
        }


    }
}
