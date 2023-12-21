using System.Linq.Expressions;

namespace Napsack
{


    internal class Knapsack
    {
        public List<Item> Items { get; set; }
        public int Maxweight { get; set; }
        public Knapsack(List<Item> items, int max)
        {
            Items = items;
            Maxweight = max;

        }
        public int Greedy()
        {
            Items.Sort();
            Items.Reverse();
            int weight = 0;
            int value = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                weight += Items[i].Weight;

                if (weight <= Maxweight)
                {
                    value += Items[i].Value;
                }
                
            }
            return value;
        }
   
        public int BruteForce()
        {
            int max = 0;
            int value = 0;
            int weight = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                weight += Items[i].Weight;
                value += Items[i].Value;
                for (int j = i; j < Items.Count; j++)
                {
                    if (weight < Maxweight)
                    {
                        weight += Items[j].Weight;
                        if(weight <= Maxweight)
                        {
                            value += Items[j].Value;
                        }
                        else
                        {
                            weight -= Items[j].Weight;
                        }
                    }
                }
                if (max < value)
                {
                    max = value;
                }
                value = 0;
                weight = 0;
                
            }
            return max;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in Items)
            {
                s += item + "\n";
            }
            return s;
        }


    }
}