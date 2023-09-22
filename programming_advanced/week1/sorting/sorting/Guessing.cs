using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    internal class Guessing
    {
        public int Guesses { get; set; }
        public int Linear(int[] array, int number)
        {
            Guesses = 0;
            for (int i = 0; i < array.Length; i++) {
                Guesses++;
                if (array[i] == number)
                { return i; }
            }
            return -1;
        }

        public int Stupid(int[] array, int number)
        {
            Guesses = 0;

            List<int> guessed  = new List<int>();
            Random random = new Random();
            do
            {
                Guesses++;
                int position = random.Next(0, array.Length);
                if (array[position] == number)
                {
                    return position;
                }
                else if (!guessed.Contains(position))
                {
                    guessed.Add(position);
                }
            }
            while (guessed.Count < array.Length);
            return -1;
        }
        public int Binary(int[] array, int number) {
            Guesses = 0;

            int low = 0;
            int high = array.Length - 1;
            while(low <= high)
            {
                Guesses++;
                int mid = (low + high)  / 2;
                if (array[mid] == number) { return mid; }
                else if (array[mid] > number)
                {
                    high = mid - 1;
                }
                else if (array[mid] < number)
                {
                    low = mid + 1;
                }
            }
            return -1;
        
        
        }

        //big O, hoeveel operaties nodig zijn om een opdracht te voltooien
        //ALTIJD LOG2 cus AAN OF UIT (BINAIR)

    }
}
