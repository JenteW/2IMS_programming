using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int input = int.Parse(Console.ReadLine());
                MagicSquare ms = new MagicSquare(input);

                
                Console.WriteLine(ms.Create(1, 1, 0));
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}