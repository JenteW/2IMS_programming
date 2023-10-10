using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    public class Assignment
    {
        public string NthCharacter(int number, string filename)
        {
            string text = File.ReadAllText(filename);
            string[] words = text.Split('\n');
            string word = "";
            foreach(string w in words)
            {
                word += w;
               
            }
            string c;
            if (word.Length > number)
            {
                c = word[number].ToString();
                return c;

            }
            else
            {
                return "/";
            }
        }
    }
}
