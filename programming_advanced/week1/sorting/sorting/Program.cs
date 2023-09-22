using System.ComponentModel;

namespace sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array =Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"),Int32.Parse);
            
            Guessing guessing = new Guessing();
            
            int number = 36;
            
            Console.WriteLine($"LINEAR {number} position {guessing.Linear(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"STUPID {number} position {guessing.Stupid(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"BINARY {number} position {guessing.Binary(array, number)} - count {guessing.Guesses}");


            number = 37;
            Console.WriteLine($"LINEAR {number} position {guessing.Linear(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"STUPID {number} position {guessing.Stupid(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"BINARY {number} position {guessing.Binary(array, number)} - count {guessing.Guesses}");


            number = 998;
            Console.WriteLine($"LINEAR {number} position {guessing.Linear(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"STUPID {number} position {guessing.Stupid(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"BINARY {number} position {guessing.Binary(array, number)} - count {guessing.Guesses}");
            
            number = -1000;
            Console.WriteLine($"LINEAR {number} position {guessing.Linear(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"STUPID {number} position {guessing.Stupid(array, number)} - count {guessing.Guesses}");
            Console.WriteLine($"BINARY {number} position {guessing.Binary(array, number)} - count {guessing.Guesses}");

        }
    }
}