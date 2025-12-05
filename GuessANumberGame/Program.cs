using System;

namespace GuessANumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool playAgain = true;

            while (playAgain)
            {
                int guess = 0;
                int minNumber, maxNumber;

                // Initial Massage
                Console.WriteLine("Welcome to the Guess a Number Game!");
                Console.WriteLine("In this game, you will set a range and try to guess the randomly generated number within that range.");

                // Get min number
                Console.WriteLine("Enter the minimum number:");
                while (!int.TryParse(Console.ReadLine(), out minNumber))
                {
                    Console.WriteLine("Please enter a valid number:");
                }

                // Get max number
                Console.WriteLine("Enter the maximum number:");
                while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber <= minNumber)
                {
                    Console.WriteLine("Please enter a valid number greater than the minimum:");
                }

                NumberGenerator generator = new NumberGenerator(minNumber, maxNumber);

                // Generate random number within range
                int number = generator.Generate();

                Console.WriteLine($"Guess a number between {minNumber} and {maxNumber}");

                int attempts = 0;

                // Guess loop
                while (guess != number)
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
                        if (guess < number)
                        {
                            Console.WriteLine("Too low! Try again.");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Too high! Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Congratulations! You've guessed the number {number} in {attempts} attempts.");
                        }
                    }
                }

                // Play again?
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