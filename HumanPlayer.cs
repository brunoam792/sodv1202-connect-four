
namespace ConnectFour
{
    public class HumanPlayer : Player
    {
// Constructor: Sets the symbol and name for the human player.
        public HumanPlayer(char symbol, string name) : base(symbol, name) { }

// Prompts the human player to choose a valid column via console input.
        public override int ChooseColumn(Board board)
        {
            return Utils.AskColumn(Name);
        }
    }
}
