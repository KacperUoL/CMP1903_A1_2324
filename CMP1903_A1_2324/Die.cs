using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private static Random diceRoll = new Random();
        public int CurrentRoll { get; private set; }

        public int Roll()
        {
            CurrentRoll = diceRoll.Next(1, 7);
            return CurrentRoll;
        }
    }

}
