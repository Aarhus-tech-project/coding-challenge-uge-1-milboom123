using System;

namespace GuessANumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
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
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts++;

                    if (guess > NumberRange)
                    {
                        Console.WriteLine("Too High");
                    }
                    else if (guess < NumberRange)
                    {
                        Console.WriteLine("Too Low");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {attempts} tries");
                    }
                }
                catch
                {
                    Console.WriteLine("Guess must be a number");
                }
            }

            Console.ReadLine();
        }
    }
}