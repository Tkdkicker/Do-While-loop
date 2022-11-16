using System;

namespace Do_While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string Easy = "Easy";
            string Medium = "Medium";
            string Hard = "Hard";
            Random Difficulty = new();

            int shipDistance = 8;
            int shotDistance;
            bool shipHasBeenShot = false;
            int shotsLeft = 0;
            int score = 0;

            Console.WriteLine("Select the level of difficult" + "\n" + "Easy" + "\n" + "Medium" + "\n" + "Hard");
            userInput = Console.ReadLine();

            if (userInput == Easy)
            {
                Console.WriteLine("You will have 10 numbers to choose from with a limit of 15 shots");
                shipDistance = Difficulty.Next(1, 10);
                shotsLeft = 15;
            }

            else if (userInput == Medium)
            {
                Console.WriteLine("You will have 50 numbers to choose from with a limit of 10 shots");
                shipDistance = Difficulty.Next(1, 50);
                shotsLeft = 10;
            }

            else if (userInput == Hard)
            {
                Console.WriteLine("You will have 100 numbers to choose from with a limit of 5 shots");
                shipDistance = Difficulty.Next(1, 100);
                shotsLeft = 5;
            }

            else
            {
                Console.WriteLine("You haven't chosen a difficulty, closing down...");
                Environment.Exit(0);
            }

            do
            {
                Console.WriteLine("Enter shooting distance");
                shotDistance = int.Parse(Console.ReadLine());

                if (shotDistance == shipDistance)
                {
                    Console.WriteLine("HIT, YOU WIN!");
                    shotsLeft -= 1;
                    score += 1;
                }

                else
                {
                    Console.WriteLine("Missed!");
                    shipHasBeenShot = true;
                    shotsLeft -= 1;
                    score -= 1;
                }
            }
            while (shipHasBeenShot == false && shotsLeft > 0 && score > 0);

            Console.WriteLine("Your total score is " + score + " with " + shotsLeft + " shots left ");
        }
    }
}