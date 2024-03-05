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
        private Game game = new Game();

        public void DebugProgram()
        {
            foreach (var die in game.Dice)
            {
                int roll = die.Roll();
                Debug.Assert(die.CurrentRoll >= 1 && die.CurrentRoll <= 6, "Dice roll out of range");
            }

            int expectedSum = game.DiceRoll(); // Roll the dice and get the expected sum

            Debug.Assert(expectedSum == game.Dice.Sum(die => die.CurrentRoll), "Sum of die rolls don't match expected sum");
        }
    }

        
    /*
     * This class should test the Game and the Die class.
     * Create a Game object, call the methods and compare their output to expected output.
     * Create a Die object and call its method.
     * Use debug.assert() to make the comparisons and tests.
     */

    //Method
}
