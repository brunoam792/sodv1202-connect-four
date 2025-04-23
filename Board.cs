
using System;

namespace ConnectFour
{
    // ---------------------- Board Class ----------------------
    // This class represents the Connect Four game board and manages game state.
    public class Board
    {
        public const int Rows = 6;
        public const int Columns = 7;
        private char[,] grid;
// Constructor: Initializes the game board with empty cells.
        public Board()
        {
            grid = new char[Rows, Columns];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    grid[i, j] = '.';
        }
        // ---------------------- Print the Board ----------------------
// Prints the current state of the board to the console.
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("1 2 3 4 5 6 7");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // ---------------------- Drop a Piece ----------------------
// Attempts to drop a piece into the specified column.
        public bool DropPiece(int column, char symbol)
        {
            if (column < 0 || column >= Columns || IsColumnFull(column)) return false;
            for (int i = Rows - 1; i >= 0; i--)
            {
                if (grid[i, column] == '.')
                {
                    grid[i, column] = symbol;
                    return true;
                }
            }
            return false;
        }
        // ---------------------- Check for a Winner ----------------------
// Checks for a winning condition on the board.
        public bool CheckWin(char symbol)
        {
            // Horizontal
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns - 3; j++)
                    if (grid[i, j] == symbol && grid[i, j + 1] == symbol && grid[i, j + 2] == symbol && grid[i, j + 3] == symbol)
                        return true;
            // Vertical
            for (int i = 0; i < Rows - 3; i++)
                for (int j = 0; j < Columns; j++)
                    if (grid[i, j] == symbol && grid[i + 1, j] == symbol && grid[i + 2, j] == symbol && grid[i + 3, j] == symbol)
                        return true;
            // Diagonal down-right
            for (int i = 0; i < Rows - 3; i++)
                for (int j = 0; j < Columns - 3; j++)
                    if (grid[i, j] == symbol && grid[i + 1, j + 1] == symbol && grid[i + 2, j + 2] == symbol && grid[i + 3, j + 3] == symbol)
                        return true;
            // Diagonal up-right
            for (int i = 3; i < Rows; i++)
                for (int j = 0; j < Columns - 3; j++)
                    if (grid[i, j] == symbol && grid[i - 1, j + 1] == symbol && grid[i - 2, j + 2] == symbol && grid[i - 3, j + 3] == symbol)
                        return true;
            return false;
        }
        // ---------------------- Check for Draw ----------------------
// Checks if the board is full, indicating a draw.
        public bool IsDraw()
        {
            for (int j = 0; j < Columns; j++)
                if (grid[0, j] == '.')
                    return false;
            return true;
        }
        // ---------------------- Check if Column is Full ----------------------
// Determines if a specific column is already full.
        public bool IsColumnFull(int column)
        {
            return grid[0, column] != '.';
        }
    }
}
