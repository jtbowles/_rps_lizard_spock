using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public string whichPlayer;

        public Human(string player)
        {
            whichPlayer = player;
        }

        public override void ChooseGesture(List<string> gestureOptions)
        {
            Console.WriteLine("  ----------------------------------------------------------");
            Console.WriteLine("   {0}, please enter the speific gesture you want to use:",name);
            Console.WriteLine("  ----------------------------------------------------------");

            foreach (string gesture in gestureOptions)
            {
                Console.WriteLine("     " + gesture);
            }
            Console.WriteLine("  ----------------------------------------------------------");


            gesture = Console.ReadLine().ToLower();
        }

        public override void ChooseName()
        {
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine("  {0}, please enter your player name:", whichPlayer);
            Console.WriteLine(" -------------------------------------------");
            name = Console.ReadLine();
        }
    }
}
