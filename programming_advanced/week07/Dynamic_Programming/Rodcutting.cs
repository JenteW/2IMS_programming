using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    internal class Rodcutting
    {
        //r_n = max(p_i + r_n-i) met 0 <= i <= n

        public int[] Prices { get; set; }
        public Rodcutting(int[] prices) 
        { 
                Prices = prices;
        }

        public int Recursion(int n)
        {
            Console.Write("Call" + n + "  ");
            if (n<0) throw new Exception("Crazy input");

            int r = 0;
            if (n == 0) return 0;
            for(int i = 1; i <= n; i++)
            {
                r = Math.Max(Prices[i] + Recursion(n - i), r);
                
            }
            return r;
        }

        public int Memoisation(int n, int[] array)
        {
            Console.Write("Call" + n + "  ");
            if (n < 0) throw new Exception("Crazy input");

            if (n == 0) return 0;
            if (array[n] != 0)
            {
                return array[n];
            }

            for (int i = 1; i <= n; i++)
            {
                //r = Math.Max(Prices[i] + Recursion(n - i), r);
                array[n] = Math.Max(Prices[i] + Memoisation(n - i, array), array[n]);

            }
            return array[n];
        }

        public int Tabulation(int n, int[] array)
        {
            Console.Write("Call" + n + "  ");
            if (n < 0) throw new Exception("Crazy input");

            if (n == 0) return 0;
            if (array[n] != 0)
            {
                return array[n];
            }
            for (int j = 1; j <= n; j++)
            {

                for (int i = 1; i <= j; i++)
                {
                    //r = Math.Max(Prices[i] + Recursion(n - i), r);
                    array[j] = Math.Max(Prices[i] + Tabulation(j - i, array), array[j]);

                }

            }
            return array[n];
        }
        /*public int tabulation(int n)
        {
            if (n < 0) throw new Exception("Crazy input!");
            int[] array = new int[n + 1];

            array[0] = 0;

            array[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n];
        }*/
    }
}
