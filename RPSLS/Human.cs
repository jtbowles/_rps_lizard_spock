using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public override void ChooseGesture(List<string> gestureOptions)
        {
            Console.WriteLine("{0}, please choose the speific gesture you want to use:",name);
            Console.WriteLine("-----------------------------------");

            foreach (string gesture in gestureOptions)
            {
                Console.WriteLine(gesture);
            }
            Console.WriteLine("-----------------------------------");
            gesture = Console.ReadLine().ToLower();
        }

        public override void ChooseName()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please enter your player name:");
            name = Console.ReadLine();
        }
    }
}
