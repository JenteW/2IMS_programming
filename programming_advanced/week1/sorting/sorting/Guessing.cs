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
        public int Linear(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == number)
                { return i; }
            }
            return -1;
        }

        public int Stupid(int[] array, int number)
        {
            List<int> guessed  = new List<int>();
            Random random = new Random();
            do
            {
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
            int low = 0;
            int high = array.Length - 1;
            while(low <= high)
            {
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


        public int Smort(int[] array, int number) {

            int mid = Math.Abs(array.Length / 2);
            int[] half;
            while (array[mid] != number)
            {
                if (array[mid] < number)
                {
                    half = new int[mid];
                    for (int i = mid + 1; i < half.Length; i++)
                    {
                        half.Append(array[i]);
                    }
                    mid = half.Length / 2;
                }
                else if (array[mid] > number)
                {
                    half = new int[array.Length / 2];
                    for (int i = mid - 1; i > 0; i--)
                    {
                        half.Append(array[i]);

                    }
                    mid = half.Length / 2;
                }
                else if (array[mid] == number)
                {
                    return mid;
                }
              
            }
            return -1;
        }
    }
}
