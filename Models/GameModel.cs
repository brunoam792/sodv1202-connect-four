using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourBR.Player
{
    internal class GameModel
    {
    }
}
public class GameModel
{
    public int[,] Board { get; private set; }

    public GameModel()
    {
        Board = new int[6, 7]; // Tabuleiro 6x7
    }

    public bool MakeMove(int column, int player)
    {
        // Lógica para fazer uma jogada
    }

    public bool CheckWin()
    {
        // Lógica para verificar vitória
    }
}
