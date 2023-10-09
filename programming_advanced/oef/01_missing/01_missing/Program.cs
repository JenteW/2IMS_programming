namespace _01_missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();
            string input = Console.ReadLine();
            string[] split = input.Split(" ");
            int[] array = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                array[i] = int.Parse(split[i]);
            }
            Console.WriteLine($"the missing value is {sorting.Sort(array)}");




        }
    }
}