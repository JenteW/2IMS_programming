using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theNth
{
    internal class Seek
    {
        public string Long(string text)
        {
            string lWord = text.Replace(" ", "");
            return lWord;
        }

        public char findChar(string text, int num)
        {


            string word = Long(text);
            char c;
            if (word.Length > num)
            {
                c = word[num];
                return c;

            }
            else
            {
                return '/';
            }

        }
    }
}
