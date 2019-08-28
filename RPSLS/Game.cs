using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public int numberOfPlayers;

        public Game()
        {
            
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine("How many players would like to play?");
            Console.WriteLine("Enter [1] or [2]");
            Console.WriteLine("-----------------------------------");
            numberOfPlayers = Int32.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void DisplayNumberOfPlayers()
        {
            Console.WriteLine("Currently playing with {0} player(s)", numberOfPlayers);
            Console.Read();
            Console.Clear();
        }

        public void DisplayGameRules()
        {
            Console.WriteLine("You will get the opportunity to choose your gesture between each of the following:");
            Console.WriteLine("[1] Rock");
            Console.WriteLine("[2] Paper");
            Console.WriteLine("[3] Scissors");
            Console.WriteLine("[4] Lizard");
            Console.WriteLine("[5] Spock");
            Console.Read();
            Console.Clear();

            Console.WriteLine("The rules of the game are as follows:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("[1] Rock crushes [3] Scissors");
            Console.WriteLine("[1] Rock crushes [4] Lizard");

            Console.WriteLine("[2] Paper covers [1] Rock");
            Console.WriteLine("[2] Paper disproves [5] Spock");

            Console.WriteLine("[3] Scissors cuts [2] Paper");
            Console.WriteLine("[3] Scissors decapitates [4] Lizard");

            Console.WriteLine("[4] Lizard poisons [5] Spock");
            Console.WriteLine("[4] Lizard eats [2] Paper");

            Console.WriteLine("[5] Spock smashes [3] Scissors");
            Console.WriteLine("[5] Spock vaporizes [1] Rock");
            Console.Read();
            Console.Clear();
        }
    }
}
