using System;
using ConnectFour.Controllers;
using ConnectFour.Models;

namespace ConnectFour.Views
{
    public class GameView
    {
        private GameController gameController;

        public GameView()
        {
            gameController = new GameController();

            // Subscribe to controller events
            gameController.GameStatusChanged += OnGameStatusChanged;
            gameController.BoardUpdated += OnBoardUpdated;
        }

        public void Start()
        {
            bool exitGame = false;

            while (!exitGame)
            {
                ShowMainMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayGame(false); // 2 player mode
                        break;
                    case "2":
                        PlayGame(true); // vs computer
                        break;
                    case "3":
                        exitGame = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            Console.WriteLine("Obrigado por jogar Connect Four!");
        }

        private void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("    CONNECT FOUR    ");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Modo 2 Jogadores");
            Console.WriteLine("2. Modo 1 Jogador (vs Computador)");
            Console.WriteLine("3. Sair");
            Console.WriteLine("=====================");
            Console.Write("Escolha uma opção: ");
        }

        private void PlayGame(bool vsComputer)
        {
            int difficulty = 1;

            if (vsComputer)
            {
                Console.Clear();
                Console.WriteLine("Escolha a dificuldade:");
                Console.WriteLine("1. Fácil");
                Console.WriteLine("2. Médio");
                Console.WriteLine("3. Difícil");
                Console.Write("Sua escolha: ");

                string difficultyChoice = Console.ReadLine();

                if (int.TryParse(difficultyChoice, out int difficultyValue) && difficultyValue >= 1 && difficultyValue <= 3)
                {
                    difficulty = difficultyValue;
                }
                else
                {
                    Console.WriteLine("Dificuldade inválida. Usando Fácil.");
                    Thread.Sleep(1000);
                }
            }

            // Start a new game
            gameController.StartNewGame(vsComputer, difficulty);

            // Game loop
            while (!gameController.IsGameOver())
            {
                int currentPlayer = gameController.GetCurrentPlayer();

                // Only prompt for input if it's a human player's turn
                if ((currentPlayer == 1 && !vsComputer) ||
                    (currentPlayer == 2 && !vsComputer) ||
                    (currentPlayer == 1 && vsComputer && gameController.GetCurrentPlayer() == 1) ||
                    (currentPlayer == 2 && vsComputer && gameController.GetCurrentPlayer() == 2))
                {
                    Console.Write("Digite o número da coluna (1-7) ou 0 para voltar ao menu: ");
                    string input = Console.ReadLine();

                    if (input == "0")
                    {
                        return; // Return to main menu
                    }

                    if (int.TryParse(input, out int column) && column >= 1 && column <= 7)
                    {
                        gameController.MakeMove(column - 1); // Convert to 0-based index
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, escolha uma coluna de 1 a 7.");
                        Thread.Sleep(1000);
                    }
                }

                // Small delay to prevent CPU usage
                Thread.Sleep(100);
            }

            // Game is over, wait for user to continue
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private void OnBoardUpdated(object sender = null, EventArgs e = null)
        {
            Console.Clear();
            DrawBoard(gameController.GetBoard());
        }

        private void OnGameStatusChanged(object sender, string status)
        {
            Console.WriteLine(status);
        }

        private void DrawBoard(int[,] board)
        {
            Console.WriteLine("\n  1 2 3 4 5 6 7");
            Console.WriteLine(" ---------------");

            for (int i = 0; i < GameModel.ROWS; i++)
            {
                Console.Write("|");

                for (int j = 0; j < GameModel.COLS; j++)
                {
                    char symbol;
                    ConsoleColor color;

                    switch (board[i, j])
                    {
                        case 1:
                            symbol = 'X';
                            color = ConsoleColor.Red;
                            break;
                        case 2:
                            symbol = 'O';
                            color = ConsoleColor.Yellow;
                            break;
                        default:
                            symbol = ' ';
                            color = ConsoleColor.White;
                            break;
                    }

                    Console.ForegroundColor = color;
                    Console.Write($"{symbol}");
                    Console.ResetColor();
                    Console.Write("|");
                }

                Console.WriteLine();
            }

            Console.WriteLine(" ---------------");
        }
    }
}