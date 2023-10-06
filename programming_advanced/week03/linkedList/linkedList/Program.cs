namespace linkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine(list);

            list.Insert(new Node("appel"));
            list.Insert(new Node("druif"));
            list.Insert(new Node("banaan"));
            Console.WriteLine(list);

            list.Insert(new Node("peer"));
            Console.WriteLine(list);
            Console.WriteLine(list.Search("peer"));

            Console.WriteLine(list.Search("beans"));

            list.Remove("peer");
            Console.WriteLine(list);
            list.Remove("appel");
            Console.WriteLine(list);
            list.Remove("banaan");
            Console.WriteLine(list);
            list.Remove("druif");
            Console.WriteLine(list);

            /*****************************STACK******************************/


            try
            {
                Stack snoep = new Stack(3);
                Console.WriteLine(snoep);
                snoep.Push("napoleons");
                snoep.Push("schepsnoep");
                snoep.Push("chocolade");
                Console.WriteLine(snoep);
                snoep.Push("hartjes");

                Console.WriteLine(snoep);
                Console.WriteLine(snoep.Pop());
                Console.WriteLine(snoep);
                Console.WriteLine(snoep.Pop());
                Console.WriteLine(snoep);
                Console.WriteLine(snoep.Pop());
                Console.WriteLine(snoep);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}