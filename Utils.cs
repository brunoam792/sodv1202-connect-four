
using System;

namespace ConnectFour
{
    // ---------------------- Utils Class ----------------------
    // This class provides static utility methods for console I/O.
    public static class Utils
    {
// Displays the welcome message and basic instructions.
        public static void PrintWelcome()
        {
            Console.WriteLine("===== CONNECT FOUR =====");
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine("Choose a column from 1 to 7.");
            Console.WriteLine();
        }
// Asks the player to input a valid column number.
        public static int AskColumn(string playerName)
        {
            int column;
            Console.Write($"{playerName}, choose a column (1-7): ");
            while (!int.TryParse(Console.ReadLine(), out column) || column < 1 || column > 7)
            {
                Console.Write("Invalid input. Enter a number from 1 to 7: ");
            }
            return column - 1;
        }
// Displays a message when the game ends in a draw.
        public static void PrintDraw()
        {
            Console.WriteLine("The game is a draw!");
        }
// Displays a message announcing the winning player.
        public static void PrintWinner(char symbol)
        {
            Console.WriteLine($"Player '{symbol}' wins!");
        }
    }
}
