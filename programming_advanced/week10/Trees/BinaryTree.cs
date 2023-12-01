using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trees
{
    internal class BinaryTree
    {
        public Node Root { get; private set; }

        public BinaryTree()
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

            if(value < node.Value)
            {
                if(node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    Add(node.Left, value);
                }
            }
            if(value > node.Value)
            {
                if(node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }



   
           /* if(node == null)
            {
                node = new Node(value);                
            }
            if(node.Value > value)
            {
                Console.WriteLine("wenen");
                node.Left = value;
                Console.WriteLine("wenen");
                return node;
            }
            if(node.Value < value)
            {
                Console.WriteLine("wenen");
                node.Right = value;
                Console.WriteLine("wenen");
                return node;
            }*/
        }
        public void TraverseInOrder()
        {
            TraverseInOrder(Root);
        }
        private void TraverseInOrder(Node node)
        {
           if(node != null)
           {
                TraverseInOrder(node.Left);
                Console.WriteLine(node.Value);
                TraverseInOrder(node.Right);
           }

        }


        public void TraversePreOrder()
        {
            TraversePreOrder(Root);
        }
        private void TraversePreOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                TraversePreOrder(node.Left);
                TraversePreOrder(node.Right);
            }
        }


        public void TraversePostOrder()
        {
            TraversePostOrder(Root);
        }
        private void TraversePostOrder(Node node)
        {
            if(node != null)
            {
                TraversePostOrder(node.Left);
                TraversePostOrder(node.Right);
                Console.WriteLine(node.Value);
            }

        }


        public bool Search(int value)
        {
            return Search(Root, value);
        }

        private bool Search(Node current, int value)
        {
            if(current == null)
            {
                return false;
            }
            
            
            if(value < current.Value)
            {
                return Search(current.Left, value);
            }
            if(value > current.Value)
            {
                return Search(current.Right, value);
            }
            return true;
        }


        public int FindMax()
        {
            Node node = Root;
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node.Value;
        }
        public int FindMaxRec()
        {
            if (Root == null) throw new Exception("Tree is empty!");
            return FindMaxRec(Root);
        }

        private int FindMaxRec(Node node)
        {

            if (node.Right == null) return node.Value;

            return FindMaxRec(node.Right);
        }
        public int FindMin()
        {
            Node node = Root;
            while(node.Left != null)
            {
                node = node.Left;
            }
            return node.Value;
        }
    }
}
