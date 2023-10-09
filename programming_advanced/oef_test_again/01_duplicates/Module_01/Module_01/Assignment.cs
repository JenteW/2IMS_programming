using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    internal class Assignment
    {
        public string Duplicates(string start, string filename)
        {
            string text = File.ReadAllText(filename);
            string[] words = text.Split('\n');
            bool check = true;
            List<string> result = new List<string>();
            char[] s = start.ToCharArray();
            string test = "";
            foreach (string word in words)
            {
                char[] c = word.ToCharArray();

                for (int i = 0; i < start.Length; i++) 
                {
                    if(c.Length < s.Length)
                    {
                        check = false;
                        break;
                    }
                    if (c[i] != s[i])
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }

                }
                if (check)
                {
                    if (result.Contains(word))
                    {
                        test = test + word + "\n";
                    }
                    else
                    {
                        result.Add(word);
                    }
                }
               
            }
            if(test == "")
            {
                return "no duplicates found";
            }

            return test;
        }
    }
}
