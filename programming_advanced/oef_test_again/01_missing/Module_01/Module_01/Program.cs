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
                array[i] = int.Parse(split[i]);
            }
            Console.WriteLine($"the missing value is {assignment.Missing(array)}");

        }
    }
}