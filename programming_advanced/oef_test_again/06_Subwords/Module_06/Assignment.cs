using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Module_06
{
    internal class Assignment
    {
        public List<string> list = new List<string>();
        public List<string> solutions = new List<string>();

        public static string[] words()
        {
            return File.ReadAllLines("english.txt");
        }
        public static bool inFile(string[] words, string input)
        {
            return words.Contains(input);
        }
        public List<string> GetWords(string input)
        {
            List<string> subwords = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 2; j <= input.Length; j++)
                {
                    string subword = input.Substring(i, j - i);
                    if (subword != input) 
                    {
                        subwords.Add(subword);
                    }

                }
            }

            return subwords.Distinct().OrderBy(s => s).ToList();
        }

        public List<string> IsValid(List<string> subwords)
        {
            List<string> validWords = new List<string>();
            string[] check = words();
            foreach (string subword in subwords)
            {
                if (inFile(check, subword))
                {
                    validWords.Add(subword);
                }
            }

            return validWords;
        }
       
    }
}
