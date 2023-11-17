namespace Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            int input = 15;
            /*int result = fibonacci.Recursion(90);
            Console.WriteLine(result);*/
            Console.WriteLine(fibonacci.memoisation(input, new double[input+1]));
            Console.WriteLine(fibonacci.tabulation(input));
            Console.WriteLine(fibonacci.Iterative(input));


            Rodcutting rod = new Rodcutting(new int[] {0,1,5,8,9,10,17,17,20,24,30 });
            int n = 4;
            Console.WriteLine(rod.Recursion(n));
            Console.WriteLine(rod.Memoisation(n, new int[n+1]));
            Console.WriteLine(rod.Tabulation(n, new int[n + 1]));
        }
    }
}