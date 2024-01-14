using System;

class Program
{
    static void Main(string[] args)
    {
        int magic_number, response_number, try_count;
        response_number = 0;
        try_count = 0;
        string response, repeat = "yes";

        do {
            magic_number = new Random().Next(1, 100);
            for (try_count = 0, response_number = 0; response_number != magic_number; try_count++)
            {
                Console.Write("What is your guess? ");
                response = Console.ReadLine();
                response_number = int.Parse(response);

                if (response_number == magic_number)
                    Console.WriteLine("You guessed it!");
                else if (response_number > magic_number)
                        Console.WriteLine("Lower");
                    else
                        Console.WriteLine("Higher");
            }

            Console.WriteLine($"Try count: {try_count}");
            Console.Write("Would you like to play again? (yes/no) ");
            repeat = Console.ReadLine().ToLower();
        } while (repeat == "yes");
    }
}