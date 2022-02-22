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
            
            string input = Console.ReadLine();
            Console.WriteLine("Welcome {0}, let's play a game . . .", input);
            Console.WriteLine();

            int correctNumber = 9;

            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

        }
    }
}