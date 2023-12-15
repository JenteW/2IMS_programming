using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Xml;
using System.Threading.Tasks;
namespace Module_10
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Assignment assignment = new Assignment();
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Tree is empty!");
                    return;
                }
                else
                {
                    input = input.ToUpper().Trim();
                }
                while (true)
                {
                    assignment.AddOrDelete(input);
                    assignment.TraverseInOrder();
                    Console.WriteLine();
                    input = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    input = input.ToUpper().Trim();

                }
            }
            
            catch
            {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}