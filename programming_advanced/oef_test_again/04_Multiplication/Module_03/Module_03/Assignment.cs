using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Assignment
    {

        public int Multiplication(int number, int times)
        {
                        
                int answer = number;
                if (times == 1)
                {
                    return answer;
                }
                return answer + Multiplication(number, times - 1);
            

        }
    }
}
