namespace ConsoleApp20;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 50;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to guess number game");
        Console.ResetColor();

        int attempts = 3;
        while (attempts >= 1)
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 50)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Congrats, you guessed the number");
                Console.ResetColor();
                break;
            }

            attempts--;

            if (attempts == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game over");
                Console.ResetColor();
                break;
            }
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Try again... (attempts: {attempts})");
            Console.ResetColor();
        }
    }
}