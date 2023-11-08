using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class LinkedList
    {
        public class Stack
        {
            public string[] stack;

            public int top;
            public Stack(int size)
            {
                stack = new string[size];
                top = 0;
            }
            public void Push(string data)
            {
                if (top == stack.Length)
                {
                    throw new Exception("Too many open symbols");
                }
                stack[top] = data;
                top++;



            }
            public string Pop()
            {
                if (top == 0)
                {
                    throw new Exception("Too many close symbols");
                }
                string temp = stack[top - 1];
                stack[top - 1] = null;
                top--; // Decrement the top index to remove the top element from the stack.
                return temp;
                



            }
            public string Top()
            {
                if (top == 0)
                {
                    return "empty";
                }

                return stack[top - 1];
            }



            public override string ToString()
            {
                return String.Join(" ", stack);
            }
        }

    }
}
