﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    internal class Fibonacci
    {
        public int Recursion(int n)
        {
            Console.Write(n + "  "); // to see how many times the method is called
            if(n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;
            else return Recursion(n - 1) + Recursion(n - 2);

        }

        public double memoisation(int n, double[] array)
        {
            Console.Write("Call" + n + "  ");

            if (n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;
            if (array[n] != 0)
            {
                return array[n]; 
            }         
            array[n] = memoisation(n - 1, array) + memoisation(n - 2, array);
            return array[n];
            /*if (array[n] == 0)
            {
                array[n] = memoisation(n - 1, array) + memoisation(n - 2, array);
            }
            return array[n];*/
            
            //return Recursion(n - 1, array) + Recursion(n - 2, array);
        }
        public int tabulation(int n)
        {
            if(n < 0) throw new Exception("Crazy input!");
            int[] array = new int[n + 1];

            array[0] = 0;

            array[1] = 1;

            for(int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i-2];
            }

            return array[n];
        }
        public int Iterative(int n)
        {
            if (n < 0) throw new Exception("Crazy input!");
            int fib0 = 0;
            int fib1 = 1;
            int fib = fib0 + fib1;

            for (int i = 2; i <= n; i++)
            {
                fib = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib;
            }

            return fib;
        }
    }
}
