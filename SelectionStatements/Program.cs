using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favoriteNumber = 8;
            int guess;
            Console.WriteLine("Welcome to the guessing game!");

            Console.WriteLine("Please enter a number between 1 - 1000: ");

            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < favoriteNumber)
            {
                Console.WriteLine("Your guess is too low. Try once more.");
            } else if (guess > favoriteNumber)
            {
                Console.WriteLine("Your guess is too high! Try again.");
            } else
            {
                Console.WriteLine("Correct!");
            }

        }
    }
}
