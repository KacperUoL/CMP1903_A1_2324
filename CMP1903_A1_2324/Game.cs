using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public Die[] Dice { get; private set; } = new Die[3];

        public Game()
        {
            for (int i = 0; i < 3; i++)
            {
                Dice[i] = new Die();
            }
        }

        public int DiceRoll()
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                int roll = Dice[i].Roll();
                Console.WriteLine($"Die {i + 1} rolled: {roll}");
                sum += roll;
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Sum of the rolled dice is: {sum}");

            return sum;
        }
    }

}
