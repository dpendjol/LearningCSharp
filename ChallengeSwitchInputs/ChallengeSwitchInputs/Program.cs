using System;

namespace ChallengeSwitchInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            StartApp();
        }

        static void StartApp()
        {
            string input;
            string[] selection = new string[3] { "String", "Integer", "Boolean" };
            string choice;

            Console.WriteLine("Enter input:");
            input = Console.ReadLine();
            foreach (string item in selection)
            {
                Console.WriteLine($"Press {(Array.IndexOf(selection, item) + 1)} for {item}");
            }
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Checking if input is a string");
                    if (IsString(input))
                    {
                        Console.WriteLine("The input is a valid string");
                    }
                    else
                    {
                        Console.WriteLine("The input is NOT a valid string");
                    }
                    break;
                case "2":
                    Console.WriteLine("Checking if input is a integer");
                    if (int.TryParse(input, out int parsedInput))
                    {
                        Console.WriteLine("The input is a valid integer");
                    }
                    else
                    {
                        Console.WriteLine("The input is NOT a valid integer");
                    }
                    break;
                case "3":
                    Console.WriteLine("Checking if input is a boolean");
                    if (bool.TryParse(input, out bool ParsedInput))
                    {
                        Console.WriteLine("The input is a valid boolean");
                    }
                    else
                    {
                        Console.WriteLine("The input is NOT a valid boolean");
                    }
                    break;
                default:
                    Console.WriteLine("Please choose 1, 2 or 3.");
                    
                    break;

            }
            Console.WriteLine("Press (c) to start again or any other key to quit");
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.Clear();
                StartApp();
            }
        }

        // Input is considered a string when it contains only letters and/or whitespaces.
        // in case of other characters such as digit's it is nog considered as a string
        static bool IsString(string inputString)
        {
            foreach (char c in inputString)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
