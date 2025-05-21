using System;

class SimpleNQueens
{
    static int[] board;
    static int size;

    static void Main()
    {
        Console.Write("Enter the size of the board (N): ");
        size = int.Parse(Console.ReadLine());
        board = new int[size];

        if (PlaceQueen(0))
        {
            PrintBoard();
        }
        else
        {
            Console.WriteLine("No solution exists.");
        }
    }

    static bool PlaceQueen(int row)
    {
        if (row == size)
            return true;

        for (int col = 0; col < size; col++)
        {
            if (IsSafe(row, col))
            {
                board[row] = col;
                if (PlaceQueen(row + 1))
                    return true;
            }
        }
        return false;
    }

    static bool IsSafe(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }

    static void PrintBoard()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(board[i] == j ? "Q " : "_ ");
            }
            Console.WriteLine();
        }
    }
}