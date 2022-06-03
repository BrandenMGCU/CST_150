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
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Want to get the user's name to make it more personal.
            Console.WriteLine("What is your name?");

            // Grab the username from the console.
            var userName = Console.ReadLine();

            Console.WriteLine("Welcome " + userName + "!" + " Let the game begin!");

            var die1 = new GameDice(6);
            var die2 = new GameDice(6);
            // We need both dice to allow for the game to start.

            GameTime(die1, die2, userName);
            // This will call the function for the game to begin.
        }

        private static void GameTime(GameDice die1, GameDice die2, string userName)
        {
            var diceRolls = 1;
            // Starting the game will give us our first roll.

            var snakeeyesmatch = false;
            // Snake eyes is a literal 1 to 1 match. 


            while (snakeeyesmatch == false)
            {
                int faceofdie1, faceofdie2;
                // We need to use both side of the die faces to get the snake eyes.

                faceofdie1 = die1.RollDie(die1);
                faceofdie2 = die2.RollDie(die2);

                Console.WriteLine("Current roll is: " + diceRolls + ": " + faceofdie1 + ", " + faceofdie2);
                // Show that the roll is happening and what the output is. 

                if (faceofdie1 == 1 && faceofdie2 == 1)
                {
                    Console.WriteLine(userName + " it took " + diceRolls + " for snake eyes O O");
                    snakeeyesmatch = true;
                    Console.Title = userName.ToUpper();
                }

                diceRolls++;
                // Keep the count for the dice rolls.
            }
        }
    }
}