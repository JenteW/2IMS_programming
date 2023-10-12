using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_02
{
    public class Assignment
    {
        public string Largest(string input) {
            try
            {
                string[] split = input.Split(' ');
                List<string> numbers = new List<string>();
                foreach (string s in split)
                {
                    numbers.Add(s);
                }

                for (int i = 0; i < numbers.Count; i++)
                {

                    for (int j = 0; j < i; j++)
                    {
                        string temp = numbers[i];
                        string temp2 = numbers[j];

                        try
                        {
                            int numcheck = Convert.ToInt32(temp);
                            if (numcheck < 0)
                            {
                                return "Crazy input!";
                            }
                            numcheck = Convert.ToInt32(temp2);
                            
                        }
                        catch
                        {
                            return "Crazy input!";
                        }
                        if (Convert.ToInt32(temp[0]) > Convert.ToInt32(temp2[0]))
                        {
                            string move = numbers[j];
                            numbers[j] = numbers[i];
                            numbers[i] = move;
                        }
                        else if (Convert.ToInt32(temp[0]) == Convert.ToInt32(temp2[0]))
                        {
                            if (temp.Length < temp2.Length)
                            {
                                string move = numbers[j];
                                numbers[j] = numbers[i];
                                numbers[i] = move;
                            }
                            else if (temp.Length == temp.Length)
                            {
                                for (int k = 0; k < temp.Length; k++)
                                {
                                    if (Convert.ToInt32(temp[k]) > Convert.ToInt32(temp2[k]))
                                    {
                                        string move = numbers[j];
                                        numbers[j] = numbers[i];
                                        numbers[i] = move;
                                    }
                                }
                            }
                        }

                    }

                }
                string oplossing = "";
                foreach (string number in numbers)
                {
                    oplossing += number;
                }
                return oplossing;
            }
            catch
            {
                return "Crazy input!";
            }
        
        }
    }
}
