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
        public List<string> options = new List<string>();

        public string LargestPalindromicSubsequence = "";

        public string NumToBinary(int num)
        {
            string binary = Convert.ToString(num, 2);
            return binary;
        }

        public void subSequence(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 2; j <= input.Length; j++)
                {
                    string subword = input.Substring(i, j - i);
                    if (subword != input)
                    {
                        options.Add(subword);
                    }

                }
            }

        }

        public void Palindrome()
        {
            foreach(string item in options)
            {
                char[] temp = item.ToCharArray();
                temp.Reverse();
                string reverse = "";
                foreach(char c in temp)
                {
                    reverse += c;
                }
                //Console.WriteLine($"{item} is item and {reverse} is reverse");
                if(item == reverse && item.Length > LargestPalindromicSubsequence.Length)
                {   
                    LargestPalindromicSubsequence = item;

                }
            }
        }

        public int LargestBinary(int num)
        {
            string binary = NumToBinary(num);
            subSequence(binary);
            Palindrome();
            int result = Convert.ToInt32(LargestPalindromicSubsequence, 2);
            return result;
        }
    }
}
