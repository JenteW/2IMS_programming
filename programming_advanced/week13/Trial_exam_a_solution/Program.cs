namespace Trial_exam_a_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*            string[] input = Console.ReadLine().Trim().Split(" ");
                */
                string[] input = "3 1 9 2".Trim().Split(" ");
                int[] nr = Array.ConvertAll(input, Int32.Parse);
                Solution solution = new Solution(nr);
                Console.WriteLine(solution.BruteForce());
                Console.WriteLine(solution.Linear());
                Console.WriteLine(solution.Greedy());
            }
            catch
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}