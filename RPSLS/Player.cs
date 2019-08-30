using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name = "";
        public string gesture = "";
        public int score = 0;


        public abstract void ChooseGesture(List<string> gestureOptions);
        public abstract void ChooseName();
    }
}
