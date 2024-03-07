using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private Game _game = new Game();

        public void DebugProgram()
        {
            foreach (var die in _game.Dice)
            {
                int roll = die.Roll();
                Debug.Assert(die.CurrentRoll >= 1 && die.CurrentRoll <= 6, "Dice roll out of range");
            }

            int expectedSum = _game.DiceRoll();

            Debug.Assert(expectedSum == _game.Dice.Sum(die => die.CurrentRoll),
                "Sum of die rolls don't match expected sum");
        }
    }
}
