
namespace SimpleGameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~ Welcome to Guess the Number ~");

            Random random = new Random();
            int number = random.Next(1, 1001);

            while (true)
            {
                Console.Write("Guess a number between 1 and 1000: ");
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
