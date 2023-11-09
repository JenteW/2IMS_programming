using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    public class MagicSquare
    {
        public int[,] Square { get; set; }
        private int size;
        private int sweetSpot;


        public MagicSquare(int square_size) // constructor
        {
            size = square_size;
            Square = new int[size, size];
            sweetSpot = size * ((size * size) + 1) / 2; // n * (n² +1)/2

           

        }
        public string Create(int row , int column, int placed)//create magic square
        {
            if (placed == size * size)
            {
                if (IsMagic())
                {
                    return ToString();
                }
                else
                {
                    return "";
                }
            }
            else
            {
                for (int i = 1; i <= size * size; i++)
                {
                    if (IsValid(i))
                    {
                        Square[row, column] = i;
                        Tuple<int, int> next = nextposition(row, column);
                        string result = Create(next.Item1, next.Item2, placed + 1);
                        if (result != "")
                        {
                            return result;
                        }
                        Square[row, column] = 0;
                    }
                }
                return "";
            }

        }

        public Tuple<int, int> nextposition(int row, int col)//find next position to fill (next column, or next column and first column again)
        {
            col++; 

            if (col == size) 
            {
                col = 0; 
                row++;   
            }

            if (row == size) 
            {
                row = 0; 
            }

            return Tuple.Create(row, col);
        }

        public bool IsValid(int number) //is it valid to place this number? Is this number already in the square?
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Square[i, j] == number)
                    {
                        return false;
                    }
                }
            }

            int sumRow = 0;
            int sumCol = 0;
            int sumDiag1 = 0;
            int sumDiag2 = 0;

            for (int i = 0; i < size; i++)
            {
                sumRow += Square[i, size - 1]; // Fix the indexing here
                sumCol += Square[size - 1, i];
                sumDiag1 += Square[i, i];
                sumDiag2 += Square[i, size - i - 1];
            }

            if (sumRow > sweetSpot || sumCol > sweetSpot || sumDiag1 > sweetSpot || sumDiag2 > sweetSpot)
            {
                return false;
            }
            

            return true;

        }

        public bool IsMagic()//is it a magic square? Checks every row/column/diagonal for the right magic constant
        {
            for (int i = 0; i < size; i++)
            {
                int rowSum = 0;
                int colSum = 0;
                for (int j = 0; j < size; j++)
                {
                    rowSum += Square[i, j];
                    colSum += Square[j, i];
                }
                if (rowSum != sweetSpot || colSum != sweetSpot)
                {
                    return false;
                }


            }
            return true;
        }

        public override string ToString()//prints magic square
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += Square[i, j] + " ";
                }
                result = result.TrimEnd();
                result += "\n";
            }
            result = result.TrimEnd();

            return result;

        }





    }
}
