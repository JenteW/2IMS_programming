namespace oef_les
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            Count count = new Count();
            Reverse reverse = new Reverse();
            Console.WriteLine("for 5: " + sum.Iterative(5));    
            Console.WriteLine("for 5: " + sum.recursive(5));
            Console.WriteLine("for 12345: " + count.Iterative(12345));
            Console.WriteLine("for 12345: " + count.recursive(12345));
            /*optional stuff*/
            Console.WriteLine("for 5: " + count.For(9,-8));

            Console.WriteLine("dog reversed becomes " + reverse.iterative("dog"));
            Console.WriteLine("dog reversed becomes " + reverse.recursive("dog"));

        }
    }
}