using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override void ChooseGesture(List<string> gestureOptions)
        {
            throw new NotImplementedException();
        }

        public override void ChooseName()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the computer's name:");
            name = Console.ReadLine();

        }
    }
}
