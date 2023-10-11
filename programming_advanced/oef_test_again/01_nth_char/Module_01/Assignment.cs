using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_01
{
    public class Assignment
    {
        public string NthCharacter(int number, string filename)
        {
            /*string text = File.ReadAllText(filename);
            string[] words = text.Split('\n');
            string word = "";
            foreach (string w in words)
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
            }*/
            /*            try
                        {
                            using (FileStream fileStream = File.OpenRead(filename))
                            {
                                if (number >= 0 && number < fileStream.Length)
                                {
                                    fileStream.Seek(number + 2, SeekOrigin.Begin); 
                                    int result = fileStream.ReadByte();
                                    char character = (char)result;
                                    return character.ToString();
                                }
                                else
                                {
                                    return "Crazy input!";
                                }
                            }
                        } catch { return "Crazy input!";}*/
            /*try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    if (number < 0)
                    {
                        return "Crazy input!";
                    }
                    int charIndex = 1;
                    int result = -1;

                    while (charIndex < number)
                    {
                        result = reader.Read();

                        if (result == -1)
                        {
                            return "Crazy input!";
                        }

                        char character = (char)result;

                        if (character != '\n' && character !=' ')
                        {
                            charIndex++;
                        }
                    }

                    return ((char)result).ToString();
                }
            }
            catch
            {
                return "Crazy input!";
            }*/

            try
            {
                string fileContent = File.ReadAllText(filename);

                if (number >= 1 && number <= fileContent.Length)
                {
                    char[] characters = fileContent.ToCharArray();
                    double n = number / 10;
                    int line = (int)Math.Floor(n);
                    char character = characters[number + line];
                    if (character != '\n')
                    {
                        return character.ToString();
                    }
                    else
                    {
                        return "Crazy input!";
                    }
                }
                else
                {
                    return "Crazy input!";
                }
            }
            catch
            {
                return "Crazy input!";
            }
        }
    }
}
