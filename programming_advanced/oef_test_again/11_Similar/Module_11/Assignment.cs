using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    internal class Assignment
    {
        private List<char> UsedChars;
        private Dictionary<char, char> matching;
        public Assignment()
        {
            UsedChars = new List<char>();
            matching = new Dictionary<char, char>();
           
        }
        public bool Similar(string s1, string s2)
        {
            s1 = s1.Trim().ToLower();
            s2 = s2.Trim().ToLower();
            if (s1.Length != s2.Length)
            {
                return false;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (!UsedChars.Contains(s2[i]))
                {
                    UsedChars.Add(s2[i]);
                    matching.Add(s2[i], s1[i]);

                }
                else if (UsedChars.Contains(s2[i]))
                {
                    if (matching[s2[i]] != s1[i])
                    {
                        return false;
                    }
                   
                }
            }
            return true;

        }
    }
}
