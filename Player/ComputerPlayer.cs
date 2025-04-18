using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourBR.Player
{
    internal class ComputerPlayer
    {
    }
}

public class ComputerPlayer : Player
{
    public ComputerPlayer(string name) : base(name) { }

    public override int GetMove()
    {
        // Lógica para obter jogada do jogador computador
    }
}
