using System;
using ConnectFour.Controllers;
using ConnectFour.Views;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            GameView gameView = new GameView();
            gameView.Start();
        }
    }
}