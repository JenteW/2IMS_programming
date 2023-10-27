using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {
        public int Sum(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            if (char.IsDigit(input[0]))
            {
                int digit = (int)char.GetNumericValue(input[0]);

                return digit + Sum(input.Substring(1));
            }

            else
            {
                return Sum(input.Substring(1));
            }

        }
    }
}
