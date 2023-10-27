using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {
        public int Occurence(char number, string line)
        {
            if (line.Length < 2 && number == line[0])
            {
                return 1;
            }
            else if(line.Length <2 && number != line[0])
            {
                return 0;
            }
            if(number == line[0])
            {
                return Occurence(number, line.Substring(1)) + 1;
            }
            else
            {
                return Occurence(number, line.Substring(1));
            }
        }
    }
}
