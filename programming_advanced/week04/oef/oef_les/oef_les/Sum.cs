using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_les
{
    internal class Sum
    {
        public int Iterative(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int recursive(int n)
        {
            if(n == 0)
            {
                return n;
            }
            return n + recursive(n - 1);
            
        }
    }
}
