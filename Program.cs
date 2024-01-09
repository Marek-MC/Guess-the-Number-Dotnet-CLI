
using System;

namespace SimpleGameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");

            Random random = new Random();
            int number = random.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number between 1 and 100: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                if (guess == number)
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number: {number}");
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
        }
    }
}
