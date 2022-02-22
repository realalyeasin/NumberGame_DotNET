using System;

namespace NumberGame
{
    class Program
    {
        static void Main(String[] args)
        {
            string appName = "NumberiT";
            string appVersion = "1.0.0";
            string author = "Al Yeasin";

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            
            string inputName = Console.ReadLine();
            Console.WriteLine("Welcome {0}, let's play a game . . .", inputName);
            Console.WriteLine();

            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 20);

                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 20");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Sorry! It's not a number");

                        Console.ResetColor();
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong Number, Try Again");

                        Console.ResetColor();
                    }

                    if (guess == correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Correct Number");

                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine("Play Again? [Y or N]");

                        string ans = Console.ReadLine().ToUpper();

                        if (ans == "Y")
                        {
                            continue;
                        }
                        else if (ans == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }

            }
        }
    }
}