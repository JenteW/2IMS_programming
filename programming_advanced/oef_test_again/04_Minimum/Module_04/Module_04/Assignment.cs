using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    internal class Assignment
    {
        public int Minimum(string[] numbers, int min)
        {
           string num = numbers[0].ToString();
           int temp = int.Parse(num);

                if ( temp < min)
                {
                    min = temp;
                }

            
            if (numbers.Length != 1)
            {
                numbers = numbers.Skip(1).ToArray();
                min = Minimum(numbers, min);  
            }

            return min;
        }

    }
}
