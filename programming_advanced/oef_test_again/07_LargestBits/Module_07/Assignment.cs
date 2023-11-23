using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07
{
    internal class Assignment
    {
        /*Read in a number and convert it to its binary representation. Find all the palindromic subsequences of that binary number and print out the largest number!

            Eg: 10
            --> binary representation 1010
            --> subsequences: 101 10 1 010 01 0 10 1 0
            --> largest palindromic subsequence: 101 = 5


            Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

 

            Input/Output
            input:
            10
            output:
            5*/
        public string BinaryNumber { get; set; }

        public int LargestPalindromicSubsequence { get; set; }

        public string NumToBinary(int num)
        {
            string binary = "";
            while (num > 0)
            {
                binary = (num % 2).ToString() + binary;
                num /= 2;
            }
            return binary;
        }

        public string subSequence(string input, string letters)
        {
            
        }
    }
}
