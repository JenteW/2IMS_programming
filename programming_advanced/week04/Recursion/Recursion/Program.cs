using TM.ProgrammingAdvanced;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check PS  >> cd C:\b2ga4suadrw
            // voor treeview = tree /f
            /*string folder = Data.Folders(@"C:\"); // maar 1 keer doen, want gaat altijd nieuwe folder maken
            Console.WriteLine(folder);  --> C:\b2ga4suadrw  */
            string folder = @"C:\b2ga4suadrw";
            Console.WriteLine(folder);
            FindKey key = new FindKey();
            key.Count = 0;
            Console.WriteLine("key verstopt in" + key.Algorithm1(folder) + " Count " + key.Count);
            key.Count = 0;
            Console.WriteLine("key verstopt in" + key.Algorithm2(folder) + " Count " + key.Count);


            Factorial factorial = new Factorial();
            Console.WriteLine("8!= " + factorial.Iterative(8));

            Console.WriteLine("8!= " + factorial.Recursive(8));

        }
    }
}