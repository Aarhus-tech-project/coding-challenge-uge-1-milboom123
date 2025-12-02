using System;

namespace GuessANumberGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string StartMessage = "Guess a number between 1 and 100";
            int NumberRange = rand.Next(1,101);
            Console.WriteLine(StartMessage);
 
            int i = 0;
            
            while(guess != NumberRange)
            {
                try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());
                        i++;

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
                            Console.WriteLine($"You guessed it! It took you {i} tries");
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