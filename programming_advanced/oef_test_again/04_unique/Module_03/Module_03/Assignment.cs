using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {
        public string Unique(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                return input;
            }

            if (input[0] == input[1])
            {
                return Unique(input.Substring(1));
            }

            else
            {
                return input[0] + Unique(input.Substring(1));
            }
        }
    }
}
