using System;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment();
            string input = Console.ReadLine();
            string[] split = input.Split(" ");
            int[] array = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                try
                {
                    array[i] = int.Parse(split[i]);

                }
                catch {
                    Console.WriteLine("Crazy input!");
                    return;
                }

            }
            string anwser = assignment.Missing(array);
            if (anwser == "-1")
            {
                Console.WriteLine("No missing number.");
            }
            else
            {
                Console.WriteLine(anwser);
            }

        }
    }
}