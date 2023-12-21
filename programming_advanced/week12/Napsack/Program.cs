﻿namespace Napsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            //item value - weight
            list.Add(new Item(10, 1));
            list.Add(new Item(5, 2));
            list.Add(new Item(40, 8));
            list.Add(new Item(45, 10));


            Knapsack sack = new Knapsack(list, 10);
            Console.WriteLine(sack);
            sack.Items.Sort();
            Console.WriteLine(sack);
            Console.WriteLine("Greedy "+ sack.Greedy());
            Console.WriteLine("Brute Force " + sack.BruteForce());
            //and now solve the problem!!
        }
    }
}