using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> pastGameWinners = new List<string>();
            Game game = new Game();
            game.RunGame();

            //if(game.isComplete == true)
            //{
            //    game.PlayAgain();
            //    pastGameWinners.Add(game.gameWinner);
            //}

            //if(game.playAgain == "yes")
            //{
            //    game = new Game();
            //}


        }
    }
}
