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
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            List<string> pastGameWinners = new List<string>();

            Game game = new Game();

            while (game.isComplete == false)
            {
                game.RunGame();
                game.PlayAgain();

                if (game.playAgain)
                {
                    pastGameWinners.Add(game.gameWinner);
                    game = new Game();
                }
                else if (!game.playAgain)
                {
                    pastGameWinners.Add(game.gameWinner);
                    PrintPastGameWinners(pastGameWinners);
                    game.isComplete = true;
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("  ------------------------------");
            Console.WriteLine("  Thank you for playing my game!");
            Console.WriteLine("  ------------------------------");
            Console.ReadLine();
        }

        private static void PrintPastGameWinners(List<string> pastGameWinners)
        {
            Console.Clear();
            foreach (string winner in pastGameWinners)
            {
                Console.WriteLine(" -------------------------------------------------");
                Console.WriteLine("  Past Winner {0} : {1}",pastGameWinners.IndexOf(winner) + 1, winner);
                Console.WriteLine(" -------------------------------------------------");
            }
        }
    }
}
