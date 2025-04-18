using ConnectFourBR.Models;
using ConnectFourBR.Player;
using ConnectFourBR;

namespace ConnectFourBR.Controllers
{
    internal class GameController
    {
    }
}

public class GameController
{
    private GameModel gameModel;
    private Player player1;
    private Player player2;
    private GameForm gameForm;

    public GameController(GameForm form)
    {
        gameModel = new GameModel();
        gameForm = form;
        player1 = new HumanPlayer("Player 1");
        player2 = new ComputerPlayer("Computer");
    }

    public void PlayGame()
    {
        // Lógica do jogo
    }

    public void MakeMove(int column)
    {
        // Lógica para fazer uma jogada
    }

    public void UpdateBoard()
    {
        gameForm.UpdateBoard(gameModel.Board);
    }
}
