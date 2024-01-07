namespace Trial_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BruteForce bruteF = new BruteForce();
                string input = "3 1 9 2 68 5";
                int[] numbers = {3,1,9,2};
                Sol2 sol2 = new Sol2(input);
                Console.WriteLine(sol2.Greedy() + " --> greedy");
                Console.WriteLine(bruteF.Brute(numbers) + " --> BruteForce");

            }
            catch
            {

                Console.WriteLine("Crazy input!");
            }

        }
    }
}