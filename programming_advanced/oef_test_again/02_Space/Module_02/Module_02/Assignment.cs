using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
                    list.Add(next);

                } while (next != "");
                /*remove last list input*/

                for (int i = 0; i < list.Count - 1; i++)
                {
                    string[] temp = list[i].Split(' ');

                    temp[1] = temp[1].Replace(',', ' ');
                    temp[1] = temp[1].Trim();
                    Console.WriteLine(temp[1]);
                    number.Add(Convert.ToInt32(temp[1]));
                    temp[3] = temp[3].Replace('"', ' ');
                    temp[3] = temp[3].Trim();
                    Console.WriteLine(temp[3]);
                    text.Add(temp[3]);

                }
                for (int i = 0; i < number.Count; i++)
                {

                    for (int j = 0; j < i; j++)
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

                return output;
            }
            catch { return "Crazy input"; }
        }
    }
}
