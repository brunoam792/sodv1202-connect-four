
using System;

namespace ConnectFour
{
    public class GameController
    {
        private Board board;
        private Player[] players;

// Constructor: Initializes the board and players.
        public GameController(Player player1, Player player2)
        {
            board = new Board();
            players = new Player[] { player1, player2 };
        }

// Starts the main game loop and handles player turns, checking for wins and draws.
        public void Start()
        {
            int currentPlayerIndex = 0;
            bool gameOver = false;

            Utils.PrintWelcome();

            while (!gameOver)
            {
                board.Print();
                Player currentPlayer = players[currentPlayerIndex];
                int column = currentPlayer.ChooseColumn(board);

                if (board.DropPiece(column, currentPlayer.Symbol))
                {
                    if (board.CheckWin(currentPlayer.Symbol))
                    {
                        board.Print();
                        Utils.PrintWinner(currentPlayer.Symbol);
                        gameOver = true;
                    }
                    else if (board.IsDraw())
                    {
                        board.Print();
                        Utils.PrintDraw();
                        gameOver = true;
                    }
                    else
                    {
                        currentPlayerIndex = (currentPlayerIndex + 1) % 2;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Column is full.");
                }
            }
        }
    }
}
