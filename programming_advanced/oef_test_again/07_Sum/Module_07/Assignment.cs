using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_07
{
    internal class Assignment
    {
        public List<int> Numbers = new List<int>();

        public int Sum(int number)
        {

            if (number <= 1)
            {  
                Numbers.Add(number);
                return number;
            }
            if (number % 2 == 0)
            {
                
                Numbers.Add(number);

                return number + Sum(number / 2);
            }
            if(number % 2 == 1)
            {
               
                Numbers.Add(number);
                return number + Sum(3 * number + 1);
            }
            return number;


        }
       public override string ToString()
        {
            string result = "";
            foreach (int number in Numbers)
            {
                result += number + " ";
            }
            return result;
        }

    }
}
