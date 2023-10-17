using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_les
{
    internal class Reverse
    {
        public string iterative(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }


        public string recursive(string word)
        {
            if (word.Length == 1) return word;

            return word[word.Length - 1] + recursive(word.Substring(0, word.Length - 1));
        }
    }
}
