using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Module_06
{

    /*Given an unsorted integer array, find the smallest (positive) number in that array

CodeGrade Setup = .Net framework 6.0

 

Input/Output
input:
1 2 3 -1 9 5 7 8
output:
4

input:
-2 -1 2 0 1 3 4
output:
No missing link

 

Code instructions

To solve this assignment you need to create a Module_06 namespace with a class and a method*/
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                List<int> list = new List<int>();
                foreach (var item in inputArray)
                {
                    list.Add(int.Parse(item));
                }
                int result = assignment.MissingLink(list);
                if (result == -1)
                {
                    Console.WriteLine("No missing link");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}