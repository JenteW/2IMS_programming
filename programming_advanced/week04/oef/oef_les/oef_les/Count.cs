using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_les
{
    internal class Count
    {
        // count the number of digits in a number
        public int Iterative(int n)
        {
            int count = 1;
            for(int i = 10; i <= n; i*= 10)
            {
                if (n < i)
                {
                    return count;
                }
                count++;
            }
            return count;
        }

        public int recursive(int n)
        {
            if (n < 10)
            {
                return 1;
            }
            return 1 + recursive(n / 10);
        }
        //print alle getallen af van 0 tot n
        public void For(int[] array, int i = 0)
        {

           if(i == array.Length - 1)
            {
                Console.WriteLine(array[i]);
                return;
            }
            Console.WriteLine(array[i]);
            For(array,i+1);
        }
        public string For(int n, int start)
        {
            if (start == n) return n.ToString();
            return start + " " + For(n, start + 1);
        }
    }
}
