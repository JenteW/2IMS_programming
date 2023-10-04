namespace theNth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seek seek = new Seek();
            string text = File.ReadAllText("test.txt");
            Console.WriteLine(text);
            Console.WriteLine(seek.Long(text));
            Console.WriteLine(seek.findChar(text, 3));
        }
    }
}