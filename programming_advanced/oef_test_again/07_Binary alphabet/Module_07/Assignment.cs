using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07
{
    internal class Assignment
    {
        public char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public string result = "";
        public string BinaryAlpha(int input)
        {
            result += " ";
            string binary = Convert.ToString(input, 2);
           /* Console.WriteLine(binary);
            Console.WriteLine();*/
            if(binary == "0")
            {
                return result;
            }
            for(int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    result += $"{alphabet[i]}";
                    //Console.Write(alphabet[i]);
                }
            }
            return BinaryAlpha(input - 1);
        }
        public string flip()
        {
            string output = "";
            string[] split = result.Split(' ');
            for(int i =split.Length - 1; i > 0; i--)
            {
                output += split[i] + " ";
               /* string temp = split[i];
                split[i] = split[i + 1];
                split[i + 1] = temp;*/
            }
            return output;
        }

       /* public string Memoisation(int n, string[] array)
        {
            Console.Write("Call" + n + "  ");
            if (n > 26) throw new Exception("Crazy input");
            string binary = Convert.ToString(n, 2);
            if (n == 0) return "";
            if (n != 0)
            {
                return array[n];
            }
            string temp = "";
            for (int i = 1; i <= n; i++)
            {
                if (binary[i] == '1')
                {
                    temp += alphabet[i];
                }                   

            }
            array[n] = Memoisation(n-1, array);
            return array[n];
        }*/



    }
}
