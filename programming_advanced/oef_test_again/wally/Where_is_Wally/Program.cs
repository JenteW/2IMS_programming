namespace Where_is_Wally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] unsortedArray = File.ReadAllLines("names.txt");
            string name = "Wally";
            Sorting sorting = new Sorting();
            string[] SelectionSortedArray = sorting.SelectionSort(unsortedArray);
            int result;
            /*SELECTION SORT*/
            try { 
                result = sorting.BinarySearch(SelectionSortedArray, name);
                if (result != -1)
                {
                    Console.WriteLine($"Found {name} at {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot find {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            /*BUBBLE SORT*/
            try
            {
                string[] BubbleSortArray = sorting.BubbleSort(unsortedArray);
                result = sorting.BinarySearch(BubbleSortArray, name);
                if (result != -1)
                {
                    Console.WriteLine($"Found {name} at {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot find {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            /*INSERTION SORT*/

            try
            { 
                string[] InsertionSortArray = sorting.InsertionSort(unsortedArray);
                result = sorting.BinarySearch(InsertionSortArray, name);
                if (result != -1)
                {
                    Console.WriteLine($"Found {name} at {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot find {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            /*SHELL SORT*/

            try
            { 
                string[] ShellSortArray = sorting.ShellSort(unsortedArray);
                result = sorting.BinarySearch(ShellSortArray, name);
                if (result != -1)
                {
                    Console.WriteLine($"Found {name} at {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot find {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            /*Gnome sort*/
            try
            {
                string[] GnomeSortArray = sorting.GnomeSort(unsortedArray);
                result = sorting.BinarySearch(GnomeSortArray, name);
                if (result != -1)
                {
                    Console.WriteLine($"Found {name} at {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot find {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}