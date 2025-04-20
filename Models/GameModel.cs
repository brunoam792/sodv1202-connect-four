using System;

namespace ConnectFour.Models
{
    public class GameModel
    {
        public const int ROWS = 6;
        public const int COLS = 7;

        private int[,] board;
        private bool gameOver;
        private int currentPlayer;
        private int winner;

        public event EventHandler<int> DiscDropped;
        public event EventHandler<int> GameWon;
        public event EventHandler GameDraw;

        public GameModel()
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            board = new int[ROWS, COLS];
            gameOver = false;
            currentPlayer = 1; // Player 1 starts
            winner = 0;

            // Initialize board with zeros (empty spaces)
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        public bool IsValidMove(int column)
        {
            if (column < 0 || column >= COLS || gameOver)
                return false;

            // Check if the column is full
            return board[0, column] == 0;
        }

        public int DropDisc(int column)
        {
            if (!IsValidMove(column))
                return -1;

            // Find the lowest empty row in the column
            int row = ROWS - 1;
            while (row >= 0 && board[row, column] != 0)
            {
                row--;
            }

            // Place the disc
            board[row, column] = currentPlayer;

            // Notify that a disc was dropped
            OnDiscDropped(column);

            // Check if the game is over
            CheckGameStatus(row, column);

            // Switch players if the game is not over
            if (!gameOver)
            {
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }

            return row;
        }

        private void CheckGameStatus(int row, int col)
        {
            // Check for a winner
            if (CheckWinner(row, col))
            {
                gameOver = true;
                winner = currentPlayer;
                OnGameWon(winner);
                return;
            }

            // Check for a draw
            bool isDraw = true;
            for (int j = 0; j < COLS; j++)
            {
                if (board[0, j] == 0)
                {
                    isDraw = false;
                    break;
                }
            }

            if (isDraw)
            {
                gameOver = true;
                OnGameDraw();
            }
        }

        private bool CheckWinner(int row, int col)
        {
            int player = board[row, col];

            // Check horizontally
            int count = 0;
            for (int j = 0; j < COLS; j++)
            {
                if (board[row, j] == player)
                {
                    count++;
                    if (count >= 4) return true;
                }
                else
                {
                    count = 0;
                }
            }

            // Check vertically
            count = 0;
            for (int i = 0; i < ROWS; i++)
            {
                if (board[i, col] == player)
                {
                    count++;
                    if (count >= 4) return true;
                }
                else
                {
                    count = 0;
                }
            }

            // Check diagonal (top-left to bottom-right)
            int startRow = row - Math.Min(row, col);
            int startCol = col - Math.Min(row, col);
            count = 0;

            while (startRow < ROWS && startCol < COLS)
            {
                if (startRow >= 0 && startCol >= 0 && board[startRow, startCol] == player)
                {
                    count++;
                    if (count >= 4) return true;
                }
                else
                {
                    count = 0;
                }

                startRow++;
                startCol++;
            }

            // Check diagonal (top-right to bottom-left)
            startRow = row - Math.Min(row, COLS - 1 - col);
            startCol = col + Math.Min(row, COLS - 1 - col);
            count = 0;

            while (startRow < ROWS && startCol >= 0)
            {
                if (startRow >= 0 && startCol < COLS && board[startRow, startCol] == player)
                {
                    count++;
                    if (count >= 4) return true;
                }
                else
                {
                    count = 0;
                }

                startRow++;
                startCol--;
            }

            return false;
        }

        public int GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool IsGameOver()
        {
            return gameOver;
        }

        public int GetWinner()
        {
            return winner;
        }

        public int[,] GetBoard()
        {
            return (int[,])board.Clone();
        }

        protected virtual void OnDiscDropped(int column)
        {
            DiscDropped?.Invoke(this, column);
        }

        protected virtual void OnGameWon(int winner)
        {
            GameWon?.Invoke(this, winner);
        }

        protected virtual void OnGameDraw()
        {
            GameDraw?.Invoke(this, EventArgs.Empty);
        }
    }
}