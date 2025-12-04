using System;

namespace GuessANumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int guess = 0;
                int minNumber, maxNumber;

                // Get minimum number
                Console.WriteLine("Enter the minimum number:");
                while (!int.TryParse(Console.ReadLine(), out minNumber))
                {
                    Console.WriteLine("Please enter a valid number:");
                }

                // Get maximum number
                Console.WriteLine("Enter the maximum number:");
                while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber <= minNumber)
                {
                    Console.WriteLine("Please enter a valid number greater than the minimum:");
                }

                // Generate the random number within user range
                int NumberRange = rand.Next(minNumber, maxNumber + 1);

                Console.WriteLine($"Guess a number between {minNumber} and {maxNumber}");

                int attempts = 0;

                // Guessing loop
                while (guess != NumberRange)
                {
                    if (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        Console.WriteLine("Guess must be a number");
                        continue;
                    }
                    if (guess < minNumber || guess > maxNumber)
                    {
                        Console.WriteLine($"Please guess a number within the range {minNumber} to {maxNumber}");
                        continue;
                    }
                    
                    attempts++;
                    {
                        if (guess < NumberRange)
                        {
                            Console.WriteLine("Too low! Try again.");
                        }
                        else if (guess > NumberRange)
                        {
                            Console.WriteLine("Too high! Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Congratulations! You've guessed the number {NumberRange} in {attempts} attempts.");
                        }
                    }
                }

                // Ask to play again
                Console.WriteLine("Do you want to play again? (y/n)");
                string answer = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (answer != "y" && answer != "yes")
                {
                    playAgain = false;
                }

                Console.WriteLine();
            }
            Console.WriteLine("Thanks for playing! Press Enter to exit.");
            Console.ReadLine();
        }
    }
}