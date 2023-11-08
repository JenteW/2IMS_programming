using System;

namespace testing
{
public class MagicSquare
    {
        public int[,] Square { get; set; }
        private int size;
        private int magicConstant;

        public MagicSquare(int square_size)
        {
            size = square_size;
            Square = new int[size, size];
            magicConstant = size * (size * size + 1) / 2;
        }

        public string Create(int row, int col, int placed)
        {
            if (placed == size * size)
            {
                return IsMagic() ? "Magic square found!" : "No magic square found!";
            }
            else
            {
                for (int num = 1; num <= size * size; num++)
                {
                    if (IsValid(num))
                    {
                        Square[row, col] = num;
                        var nextPos = NextPosition(row, col);
                        var result = Create(nextPos.Item1, nextPos.Item2, placed + 1);
                        if (result == "Magic square found!")
                        {
                            return result;
                        }
                        Square[row, col] = 0; // Backtrack
                    }
                }
                return "No magic square found!";
            }
        }

        public Tuple<int, int> NextPosition(int row, int col)
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

        public bool IsValid(int number)
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
            return true;
        }

        public bool IsMagic()
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
                if (rowSum != magicConstant || colSum != magicConstant)
                {
                    return false;
                }
            }

            int diag1Sum = 0;
            int diag2Sum = 0;
            for (int i = 0; i < size; i++)
            {
                diag1Sum += Square[i, i];
                diag2Sum += Square[i, size - 1 - i];
            }

            return diag1Sum == magicConstant && diag2Sum == magicConstant;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += Square[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }

        public static void Main(string[] args)
        {
            int size = 3; // Change the size to the desired magic square size
            MagicSquare magicSquare = new MagicSquare(size);
            string result = magicSquare.Create(0, 0, 1);
            Console.WriteLine(result);
            if (result == "Magic square found!")
            {
                Console.WriteLine(magicSquare.ToString());
            }
        }
    }

}
