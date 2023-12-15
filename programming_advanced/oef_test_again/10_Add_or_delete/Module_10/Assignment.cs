using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Xml;
using System.Threading.Tasks;



namespace Module_10
{
    internal class Assignment
    {
        public Node root { get; private set; }

        public Assignment()
        {
            root = null;
        }
        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                Add(root, value);
            }
        }
        public void AddOrDelete(string input)
        {
            string[] values = input.Split(' ');
            if (values[0] == "A")
            {
                AddIntoTree(values.Skip(1).ToArray());
            }
            else if (values[0] == "D")
            {
                Delete(values.Skip(1).ToArray());
            }
            else {                 
                Console.WriteLine("Crazy input!");
                }
            
        }
        public void Delete(string[] values)
        {
            foreach (var value in values)
            {
                Delete(Convert.ToInt32(value));
            }
        }
        public void Delete(int value)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }
            if (root.Value == value && root.Left == null && root.Right == null)
            {
                root = null;
                return;
            }
            
            Delete(root, value);
            
        }
        private Node Delete(Node node, int value)
        {
            if (node == null)
                return node;

            if (value < node.Value)
                node.Left = Delete(node.Left, value);
            else if (value > node.Value)
                node.Right = Delete(node.Right, value);
            else
            {
                if(node.Left == null && node.Right == null)
                {
                    return null;
                }
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Value = MinValue(node.Right);

                node.Right = Delete(node.Right, node.Value);
            }

            return node;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }

            
        public void AddIntoTree(string[] values)
        {
            foreach (var value in values)
            {
                Add(Convert.ToInt32(value));
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
        public bool Search(int value)
        {
            return Search(root, value);
        }

        private bool Search(Node current, int value)
        {
            if (current == null)
            {
                return false;
            }
            if (value < current.Value)
            {
                return Search(current.Left, value);
            }
            if (value > current.Value)
            {
                return Search(current.Right, value);
            }
            return true;
        }
        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }
        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left);
                Console.Write(node.Value + " ");
                TraverseInOrder(node.Right);
            }
            

        }
    }
}
