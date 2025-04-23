
using System;

namespace ConnectFour
{
    public class ComputerPlayer : Player
    {
        private Random random;

// Constructor: Initializes the computer player with a symbol and name.
        public ComputerPlayer(char symbol) : base(symbol, "Computer")
        {
            random = new Random();
        }

// Chooses a random valid column for the computer to play.
        public override int ChooseColumn(Board board)
        {
            int column;
            do
            {
                column = random.Next(0, Board.Columns);
            } while (board.IsColumnFull(column));

            Console.WriteLine($"Computer chooses column {column + 1}");
            return column;
        }
    }
}
