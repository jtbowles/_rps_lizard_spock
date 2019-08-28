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

    }
}
