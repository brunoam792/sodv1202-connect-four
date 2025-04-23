
using System;

namespace ConnectFour
{
    class Program
    {
// Main method: Prompts user for game mode and initializes the players accordingly.
        static void Main(string[] args)
        {
            Console.WriteLine("===== CONNECT FOUR =====");
            Console.WriteLine("1. Single Player (vs Computer)");
            Console.WriteLine("2. Two Players");
            Console.Write("Choose game mode (1 or 2): ");
            
            string input = Console.ReadLine();
            Player player1 = new HumanPlayer('X', "Player 1");
            Player player2;

            if (input == "1")
            {
                player2 = new ComputerPlayer('O');
            }
            else
            {
                player2 = new HumanPlayer('O', "Player 2");
            }

            GameController game = new GameController(player1, player2);
            game.Start();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
