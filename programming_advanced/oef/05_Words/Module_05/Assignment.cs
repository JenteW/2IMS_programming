using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    public class Assignment
    {
        public List<string> list = new List<string>();
        public List<string> solutions = new List<string>();

        public string[] words()
        {
            return File.ReadAllLines("english.txt");
        }
        public bool inFile(string[] words, string input)
        {
            return words.Contains(input);
        }
        public void Backtrack(string word, string current)
        {
            if (word.Length == 0)
            {
                list.Add(current);
                return;
            }

            for (int i = 1; i <= word.Length; i++)
            {
                string nextWord = word.Substring(i);
                string nextCurrent = current + " " + word.Substring(0, i);

                Backtrack(nextWord, nextCurrent);
            }
        }
        public void SearchWords(string[] words)
        {
            foreach (string s in list)
            {
                string[] strings = s.Split(' ');
                foreach (string word in strings)
                {
                    if (inFile(words, word))
                    {
                        if (solutions.Contains(word) == false)
                        {
                            solutions.Add(word);
                        }
                    }
                }

            }

        }
        public override string ToString()
        {
            string result = "";
            foreach (string s in solutions)
            {
                result += s + " ";
            }
            return result;
        }

    }
}
