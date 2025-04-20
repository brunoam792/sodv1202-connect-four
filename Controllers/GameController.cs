using System;
using System.Threading;
using ConnectFour.Models;
using ConnectFour.Players;

namespace ConnectFour.Controllers
{
    public class GameController
    {
        private GameModel gameModel;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private Random random;

        public event EventHandler<string> GameStatusChanged;
        public event EventHandler BoardUpdated;

        public GameController()
        {
            gameModel = new GameModel();
            random = new Random();

            // Subscribe to game model events
            gameModel.DiscDropped += OnDiscDropped;
            gameModel.GameWon += OnGameWon;
            gameModel.GameDraw += OnGameDraw;
        }

        public void StartNewGame(bool vsComputer, int difficulty = 1, bool randomStart = true)
        {
            gameModel.InitializeGame();

            // Initialize players
            player1 = new HumanPlayer(1);

            if (vsComputer)
            {
                player2 = new ComputerPlayer(2, difficulty);

                // Optionally randomize who starts
                if (randomStart && random.Next(2) == 1)
                {
                    // Computer starts - need to switch player IDs
                    gameModel.InitializeGame(); // Reset the game
                    player1 = new ComputerPlayer(1, difficulty);
                    player2 = new HumanPlayer(2);
                }
            }
            else
            {
                player2 = new HumanPlayer(2);
            }

            currentPlayer = (gameModel.GetCurrentPlayer() == 1) ? player1 : player2;

            // Notify the view
            OnBoardUpdated();
            OnGameStatusChanged($"É a vez do Jogador {gameModel.GetCurrentPlayer()} {GetPlayerSymbol(gameModel.GetCurrentPlayer())}");

            // If computer goes first, make its move
            if (currentPlayer is ComputerPlayer)
            {
                MakeComputerMove();
            }
        }

        public void MakeMove(int column)
        {
            if (gameModel.IsGameOver())
            {
                return;
            }

            // If it's not the human player's turn, ignore
            if (currentPlayer is ComputerPlayer)
            {
                return;
            }

            int result = gameModel.DropDisc(column);

            if (result >= 0)
            {
                // Update current player
                currentPlayer = (gameModel.GetCurrentPlayer() == 1) ? player1 : player2;

                // If it's the computer's turn, make its move
                if (!gameModel.IsGameOver() && currentPlayer is ComputerPlayer)
                {
                    MakeComputerMove();
                }
            }
        }

        private void MakeComputerMove()
        {
            // Add a small delay to make the computer's move more natural
            Thread.Sleep(500);

            if (currentPlayer is ComputerPlayer computerPlayer)
            {
                int column = computerPlayer.MakeMove(gameModel.GetBoard());

                if (column >= 0)
                {
                    Console.WriteLine($"O computador escolhe a coluna {column + 1}");
                    gameModel.DropDisc(column);

                    // Update current player
                    currentPlayer = (gameModel.GetCurrentPlayer() == 1) ? player1 : player2;
                }
            }
        }

        private void OnDiscDropped(object sender, int column)
        {
            int currentPlayerNum = gameModel.GetCurrentPlayer();

            OnBoardUpdated();
            OnGameStatusChanged($"É a vez do Jogador {currentPlayerNum} {GetPlayerSymbol(currentPlayerNum)}");
        }

        private void OnGameWon(object sender, int winner)
        {
            OnBoardUpdated();
            OnGameStatusChanged($"Jogador {winner} {GetPlayerSymbol(winner)} venceu!");
        }

        private void OnGameDraw(object sender, EventArgs e)
        {
            OnBoardUpdated();
            OnGameStatusChanged("Jogo empatado!");
        }

        public int[,] GetBoard()
        {
            return gameModel.GetBoard();
        }

        public bool IsGameOver()
        {
            return gameModel.IsGameOver();
        }

        public int GetCurrentPlayer()
        {
            return gameModel.GetCurrentPlayer();
        }

        private string GetPlayerSymbol(int playerId)
        {
            return playerId == 1 ? "(X)" : "(O)";
        }

        protected virtual void OnGameStatusChanged(string status)
        {
            GameStatusChanged?.Invoke(this, status);
        }

        protected virtual void OnBoardUpdated()
        {
            BoardUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}