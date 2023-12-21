using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Module_11
{
    internal class Assignment
    {
        public string[] GetFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public List<int> GetASCII(string input)
        {
            input = input.ToLower();
            List<int> ascii = new List<int>();

                foreach (char c in input)
                {
                    ascii.Add((int)c);
                }
            return ascii;
        }


        public string Check(List<int> ascii, string[] names)
        {
            int count = 0;
            string shifter = "";
            while (!names.Contains(shifter))
            {
                shifter = "";
                foreach (int i in ascii)
                {
                    int temp = i - 1;
                    if (temp < 97)
                    {
                        temp = 122;
                    }
                    shifter += (char)temp;
                }
                ascii = GetASCII(shifter);
                count++;
                if(count >= 26)
                {
                    return "Crazy input!";
                }

            }
            return $"Shift {count} - {shifter.ToUpper()}";
        }
    }
}
