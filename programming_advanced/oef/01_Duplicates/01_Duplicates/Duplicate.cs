using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Duplicates
{
    internal class Duplicate
    {
        public List<string> dupe(List<string> input) { 
        
            string search = Console.ReadLine();
            char[] c = search.ToCharArray();
            List<string> result = new List<string>();
            foreach (string s in input) {
                bool check = true;


                for (int i = 0; i < c.Length; i++)
                {
                    if (s[i] != c[i])
                    {
                        check = false;
                    }

                    
                   
                }
                if (check == true)
                {
                    result.Add(s);
                }
                check = true;

            }


            return result;
        
        
        }
    }
}
