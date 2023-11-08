using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    public class Assignment
    {
        public void Sum(int input, List<int> numbers, int startpoint)
        {
            if(input == 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }
            
            for(int i = startpoint; i <= input; i++)
            {
                numbers.Add(i);
                Sum(input - i, numbers, i);
                numbers.RemoveAt(numbers.Count - 1);
            }

        }

    }
}
