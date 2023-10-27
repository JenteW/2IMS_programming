using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {
        public int Occurence(int number, string[] line)
        {
            int num = int.Parse(line[0]);
            if (line.Length < 2 && number ==  num)
            {
                return 1;
            }
            else if(line.Length <2 && number !=  num)
            {
                return 0;
            }
            if(number == num)
            {
                return Occurence(number, line.Skip(1).ToArray()) + 1;
            }
            else
            {
                return Occurence(number, line.Skip(1).ToArray());
            }
        }
    }
}
