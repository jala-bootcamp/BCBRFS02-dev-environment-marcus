namespace Randomize;

static class Program
{
    static void Main()
    {
        Random random = new();

        while (true)
        {
            Console.Write("Enter the first integer (or 'exit' to quit): ");
            string? firstInput = Console.ReadLine();

            if (firstInput is not null && firstInput.ToLower() == "exit")
            {
                break;
            }

            int firstInteger;
            if (!int.TryParse(firstInput, out firstInteger))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            Console.Write("Enter the second integer: ");
            string? secondInput = Console.ReadLine();

            int secondInteger;
            if (!int.TryParse(secondInput, out secondInteger))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (firstInteger >= secondInteger)
            {
                Console.WriteLine("Invalid input. The second integer has to be greater than the first integer.");
                continue;
            }

            int randomNumber = random.Next(firstInteger, secondInteger + 1);
            Console.WriteLine($"The generated random number is: {randomNumber}");
            Console.WriteLine();
        }
    }
}
