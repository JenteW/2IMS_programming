using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_02
{
    public class Assignment
    {
        public string Space(string input)
        {
            try
            {
                List<string> list = new List<string>();
                List<int> number = new List<int>();
                List<string> text = new List<string>();
                string next = input;
                list.Add(next);
                do
                {
                    next = Console.ReadLine();
                    if (!string.IsNullOrEmpty(next))
                    {
                        list.Add(next);
                    }

                } while (!string.IsNullOrWhiteSpace(next));


                for (int i = 0; i < list.Count; i++)
                {
                    string[] temp = list[i].Split(' ');

                    temp[1] = temp[1].Replace(',', ' ');
                    temp[1] = temp[1].Trim();
                    number.Add(Convert.ToInt32(temp[1]));
                    if (!temp[3].Contains('"'))
                    {
                        return "Crazy input!";
                    }
                    temp[3] = temp[3].Replace('"', ' ');
                    temp[3] = temp[3].Trim();
                    text.Add(temp[3]);

                }
                for (int i = 0; i < number.Count; i++)
                {

                    for (int j = 0; j < number.Count - 1 - i; j++)
                    {
                        if (number[j] > number[j + 1])
                        {
                            //check het getal
                            int b = number[j];
                            number[j] = number[j + 1];
                            number[j + 1] = b;
                            // verander de positie van de text
                            string s = text[j];
                            text[j] = text[j + 1];
                            text[j + 1] = s;
                        }
                    }

                }

                string output = "";

                foreach (string s in text) { output += $"{s} "; }
                if(output.Length > 1)
                {
                    return output.Trim();

                }
                else
                {
                    return "Crazy input!";
                }
            }
            catch { return "Crazy input!"; }
        }
    }
}
