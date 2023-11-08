using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {
        public string Balance(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{' || c == '<')
                {
                    count++;
                }
            }
            LinkedList.Stack stack = new LinkedList.Stack(count);
            string bracket = "";
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{' || c == '<' || c == ')' || c == ']' || c == '}' || c == '>')
                {
                    bracket += c;
                }
            }
            foreach (char c in bracket)
            {
                if (c == '(' || c == '[' || c == '{' || c == '<')
                {
                    stack.Push(c.ToString());
                }
                else if (c == ')' && stack.Top() == "(")
                {

                    stack.Pop();
                    count--;

                }
                else if (c == ']' && stack.Top() == "[")
                {

                    stack.Pop();
                    count--;



                }
                else if (c == '}' && stack.Top() == "{")
                {

                    stack.Pop();
                    count--;



                }
                else if (c == '>' && stack.Top() == "<")
                {

                    stack.Pop();
                    count--;



                }
                else if (stack.Top() == "empty")
                {
                    count--;

                }
                /*else if (c == '(' && stack.Top() != ")" || c == ']' && stack.Top() != "[" || c == '}' && stack.Top() != "{" || c == '>' && stack.Top() != "<")
                {
                     return "Unbalanced expression!";
                }*/
                else
                {
                      return "Not balanced expression";
                }

            }
            if (count < 0)
            {
                return "Too many close symbols";
            }
            else if (count > 0) 
            {                 
                return "Too many open symbols";
            }
            return "Balanced expression!";

        }
    }
}
