using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();
                if(input1 == "" || input2 == "" || input3 == "")
                {
                   Console.WriteLine("Crazy input!");
                }

                assignment.Player(input1, input2, input3);
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}