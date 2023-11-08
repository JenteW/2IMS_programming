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

        }

        public Tuple<int, int> nextposition(int row, int col)//find next position to fill (next column, or next column and first column again)
        {

        }

        public bool IsValid(int number) //is it valid to place this number? Is this number already in the square?
        { 
            
        
        
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

            }
        public override string ToString()//prints magic square
        {

        }





    }
}
