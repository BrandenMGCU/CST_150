/* Branden M.
 06.02.22
 Activity 11
 CST-150 
 Prof. Mark Smithers
 Grand Canyon University
 */
using System;

namespace Activity_11_CST_150
{
    public class GameDice
    {
        private int _sidesOfDice;
        /*
         * Want to be able to get the
         * current side(s) of the die.
         */

        private int _valueOfDice;
        /*
         * Want to get the current value
         * from the current side of the
         * die.
         */

        public GameDice()
        {
            _sidesOfDice = 6;
            // Could be number 1 - 6.
        }

        public GameDice(int diesides)
        {
            // Want to have a 'random' dice roll.

            if ((diesides >= 4) & (diesides <= 20))
            {
                _sidesOfDice = diesides;
            }
            else
            {
                Console.Beep();
                // Beep so you know there was an error. 

                Console.WriteLine("This dice will not work for what we need!");
                // The dice did not meet the requirements for the program to work.

                _sidesOfDice = 6;
            }
        }

        public int RollDie(GameDice dice)
        {
            var number1 = new Random();

            dice._valueOfDice = number1.Next(1, _sidesOfDice + 1);

            return dice._valueOfDice;
        }
    }
}