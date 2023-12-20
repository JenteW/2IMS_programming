using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module_10
{
    public class Assignment
    {

        public Node Root { get; private set; }

        public Assignment()
        {
            Root = null;
        }
        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Add(Root, value);
            }
        }

        private void Add(Node node, int value)
        {

            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Add(node.Left, value);
                }
            }
            if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }

        }
        public string BFS()
        {   Node startnode = Root;
            Queue<Node> queue = new Queue<Node>();
            List<int> visited = new List<int>();

            queue.Enqueue(startnode);

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();

                if (!visited.Contains(node.Value))
                {
                    visited.Add(node.Value);
                    if(node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if(node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
            }
            return String.Join(" ", visited);

        }
       
    }
}
