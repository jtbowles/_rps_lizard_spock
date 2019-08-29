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
            throw new NotImplementedException();
        }

        public override void ChooseName()
        {
            Console.WriteLine("Please enter your player name:");
            name = Console.ReadLine();
            Console.Clear();
        }
    }
}
