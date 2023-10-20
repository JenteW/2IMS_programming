namespace nQueen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queen queen = new Queen(8);
            queen.Solve(0);
            Console.WriteLine(queen);*/
            
            
            Subset subset = new Subset();
            List<List<int>> results =subset.Solve(new int[] {4 , 8 , 10});
           
            foreach(var item in results)
            {
                Console.WriteLine(String.Join(" ",item));
                
            }
            results = subset.SolveBinary(new int[] { 4, 8, 10 });
            foreach (var item in results)
            {
                Console.WriteLine(String.Join(" ", item));
            }


        }
    }
}