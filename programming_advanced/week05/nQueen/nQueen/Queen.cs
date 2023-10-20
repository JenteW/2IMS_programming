using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nQueen
{
    public class Queen
    {
        int[,] board;
        int n;

        public Queen(int size)
        {
            board = new int[size, size];
            n = size;
        }

        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    s += board[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }



       /* public bool Safe(int[,] board, int row, int col)
        {
            for (int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                    return false;
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            for (int i = row, j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            return true;
        }

        public bool PlaceQueens(int[,] board, int col)
        {
            if (col >= n)
                return true;

            for (int i = 0; i < n; i++)
            {
                if (Safe(board, i, col))
                {
                    board[i, col] = 1;

                    if (PlaceQueens(board, col + 1))
                        return true;

                    board[i, col] = 0; // Backtrack
                }
            }

            return false;
        }*/

        private bool IsSafe(int row, int col)
        {
            for(int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                    return false;
            }
            for(int i = row , j = col; i >= 0 && j >= 0; i--, j--){
                
                if (board[i, j] == 1)
                    return false;
            }
            for(int i = row,  j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;

                }
            }
            return true;
               
            

        }
        public bool Solve(int col)
        {
            Console.WriteLine(ToString());
            if (col >= n) return true;

            for(int i = 0; i < n; i++)
            {
                if (IsSafe(i, col))
                {
                    board[i, col] = 1;

                    bool result = Solve(col + 1);
                    if (result) return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }

    }
    

}
