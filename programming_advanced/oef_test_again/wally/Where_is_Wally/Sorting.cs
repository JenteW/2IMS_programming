using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where_is_Wally
{
    public class Sorting
    {
        /*SELECTION SORT*/
        public string[] SelectionSort(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (string.Compare(names[j], names[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    string temp = names[i];
                    names[i] = names[minIndex];
                    names[minIndex] = temp;
                }
            }
            return names;
        }

        /*BUBBLE SORT*/
        public string[] BubbleSort(string[] names)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < names.Length - 1; i++)
                {
                    if (string.Compare(names[i], names[i + 1]) > 0)
                    {
                        string temp = names[i];
                        names[i] = names[i + 1];
                        names[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return names;
        }
        /*INSERTION SORT*/
        public string[] InsertionSort(string[] names)
        {
            for (int i = 1; i < names.Length; i++)
            {
                string key = names[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(names[j], key) > 0)
                {
                    names[j + 1] = names[j];
                    j = j - 1;
                }

                names[j + 1] = key;
            }
            return names;
        }

        /*SHELL SORT*/
        public string[] ShellSort(string[] names)
        {
            int n = names.Length;

            // Start with a large gap and reduce it
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    string temp = names[i];
                    int j;

                    // Move elements of arr[0..i-gap] that are greater than the current element arr[i]
                    for (j = i; j >= gap && string.Compare(names[j - gap], temp) > 0; j -= gap)
                    {
                        names[j] = names[j - gap];
                    }

                    // Insert the current element arr[i] into the correct position
                    names[j] = temp;
                }
            }
            return names;
        }
        public string[] GnomeSort(string[] names)
        {
            int len = names.Length;
            int i = 0;

            while (i < len)
            {
                if (i == 0)
                {
                    i++;
                }
                if (string.Compare(names[i], names[i - 1], StringComparison.Ordinal) >= 0) // stringComparison.ordinal compares the unicode value of both strings
                {
                    i++;
                }
                else
                {
                    string temp = names[i];
                    names[i] = names[i - 1];
                    names[i - 1] = temp;
                    i--;
                }
            }
            return names;
        }


        /*BINARY SEARCH*/
        public int BinarySearch(string[] names, string target)
        {
            int left = 0;
            int right = names.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int compareResult = string.Compare(names[mid], target);

                if (compareResult == 0)
                {
                    return mid; // Target found
                }

                if (compareResult < 0)
                {
                    left = mid + 1; // Target is in the right half
                }
                else
                {
                    right = mid - 1; // Target is in the left half
                }
            }

            return -1; // Target not found
        }
    }
}
