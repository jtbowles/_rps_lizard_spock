using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public Random random;
        public int index;

        public override void ChooseGesture(List<string> gestureOptions)
        {
            random = new Random();
            index = random.Next(gestureOptions.Count);
            gesture = gestureOptions[index];
        }

        public override void ChooseName()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the computer's name:");
            name = Console.ReadLine();

        }
    }
}
