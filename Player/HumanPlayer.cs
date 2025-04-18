using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourBR.Player
{
    internal class HumanPlayer
    {
    }
}

public class HumanPlayer : Player
{
    public HumanPlayer(string name) : base(name) { }

    public override int GetMove()
    {
        // Lógica para obter jogada do jogador humano
    }
}

