using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    internal class Assignment
    {
        public Node Root { get; private set; }
        int leftHeight = 0;
        int rightHeight = 0;
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
        public string Balanced(Node node)
        {
            TraverseInOrder();
            int dif = leftHeight - rightHeight;
            dif = Math.Abs(dif);
            if (dif <= 1)
            {
                return "balanced";
            }
            else
            {
                return "not balanced";
            }

        }
        public void createTree(string input)
        {
            input = input.Trim();
            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Add(numbers[i]);
            }
        }
        public void TraverseInOrder()
        {
            TraverseInOrder(Root);
        }
        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {
               
                TraverseInOrder(node.Left);
                if (node.Value < Root.Value)
                {
                    leftHeight++;
                }
                else if (node.Value > Root.Value)
                {
                    rightHeight++;
                }
                TraverseInOrder(node.Right);
            }

        }   
    }
}
