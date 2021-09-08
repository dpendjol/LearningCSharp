using System;

namespace ChallengeTicTacToe
{
    /*
     * Create the game Tic Tac Toe
     * The requirements are:
       * It is a two player game
       * It has to have reset functionality
       * A field cannot be selected 2 times
       * A input < 0 or > 9 is not allowed
       * A input of letters or other symbols then digits is not allowed
       * 
     * 
     */
    class Program
    {
        private static string[,] playField = new string[3,3] { 
            { "O", "2", "3" }, 
            { "4", "5", "6" }, 
            { "7", "8", "O" } 
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DisplayField(playField);
            MakeAMove("PlayerOne");
            DisplayField(playField);
            Console.WriteLine("Player one: " + IsThereAWinner(playField, "O"));
            Console.WriteLine("Player two: " + IsThereAWinner(playField, "X"));
        }

        static string IsThereAWinner(string[,] CurrentField, string player)
        {
            Console.WriteLine("*** Checking for winner");
            if ((CurrentField[0, 0] == player && CurrentField[0, 1] == player && CurrentField[0, 2] == player) || //row 1 is the same
                (CurrentField[1, 0] == player && CurrentField[1, 1] == player && CurrentField[1, 2] == player) || //row 2 is the same
                (CurrentField[2, 0] == player && CurrentField[2, 1] == player && CurrentField[2, 2] == player) || //row 3 is the same
                (CurrentField[0, 0] == player && CurrentField[1, 0] == player && CurrentField[2, 0] == player) || //column 1 is the same
                (CurrentField[0, 1] == player && CurrentField[1, 1] == player && CurrentField[2, 1] == player) || //column 2 is the same
                (CurrentField[0, 2] == player && CurrentField[1, 2] == player && CurrentField[2, 2] == player) || //column 3 is the same
                (CurrentField[0, 0] == player && CurrentField[1, 1] == player && CurrentField[2, 2] == player) || //diag l-r is the same
                (CurrentField[0, 2] == player && CurrentField[1, 1] == player && CurrentField[2, 0] == player) )//diag r-l is the same
            {
                return player == "O" ? "PlayerOne" : "PlayeTwo";
            }
            else
            {
                return "no winner yet";
            }



    
        }
        static bool MakeAMove(string player)
        {
            Console.WriteLine("Lets play Tic Tac Toe");
            Console.WriteLine("Please choose a field:");
            string input = Console.ReadLine();
            bool validInput = int.TryParse(input, out int numInput);
            if (validInput)
            {
                for (int i = 0; i < playField.GetLength(0); i++)
                {
                    for (int j = 0; j < playField.GetLength(1); j++)
                    {
                        if (playField[i, j].Equals(input))
                        {
                            playField[i, j] = player == "PlayerOne" ? "O" : "X";
                        } 
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("This is not a valid input. Please try again");
                MakeAMove(player);
                return false;
            }
        }

        /// <summary>
        /// Display the current status of the field in the console.
        /// </summary>
        /// <param name="CurrentField">2 dimensional array</param>
        static void DisplayField(string[,] CurrentField)
        {
            for (int i = 0; i < CurrentField.GetLength(0); i++)
            {
                Console.WriteLine("     |     |     ");
                for (int j = 0; j < CurrentField.GetLength(1); j++)
                {
                    if (j != CurrentField.GetLength(1) - 1)
                    {
                        Console.Write("  " + CurrentField[i, j] + "  |");
                    }
                    else
                    {
                        Console.Write("  " + CurrentField[i, j] + "  ");
                    }
                    }
                Console.Write("\n");
                Console.WriteLine("     |     |     ");
                string toDisplay = i != CurrentField.GetLength(0) - 1 ? "-----+-----+-----" : "";
                Console.WriteLine(toDisplay);
            }
        }
    }
}
