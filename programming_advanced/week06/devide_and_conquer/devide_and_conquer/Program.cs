namespace devide_and_conquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            int[] array = new int[] { 2,7,-8,3,5,10,4,8,-5,1,-4,-10,12,27};

            Console.WriteLine(sum.SolveIterative(array));
            Console.WriteLine(sum.SolveRecusive(array));
            Console.WriteLine(sum.ListRecursive(array.ToList()));

            List<int> list = new List<int>(array);
            Console.WriteLine(String.Join(",", list) );
            QuickSort quicksort = new QuickSort();
            quicksort.Solve(list);
            Console.WriteLine(String.Join(",", list));

            Hanoi hanoi = new Hanoi();
            hanoi.Solve(4, 'A', 'B', 'C');


        }
    }
}