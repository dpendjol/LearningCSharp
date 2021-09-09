using System;
using System.Diagnostics;

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
        private static char[,] playField = new char[3,3] { 
            { '1','2','3' }, 
            { '4','5','6' }, 
            { '7','8','9' } 
        };
        // number of fields that have been chosen
        private static int turn = 0;
        private static bool endProgram = false;
        static void Main(string[] args)
        {
            bool somebodyWon = false;
            
            while (!somebodyWon && !endProgram)
            {
                Console.Clear();
                Console.WriteLine("Let us play Tic Tac Toe");
                Console.WriteLine("Player one: O --- Player two: X");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Press 'q' to quit, press 'r' to restart");
                Console.WriteLine("-------------------------------");

                // Debug statement //
                //System.Diagnostics.Debug.WriteLine("Turn: " + turn);
                // Debug statement //

                DisplayField(playField);

                if (turn % 2 == 0)
                {
                    Console.WriteLine("Player one, pick your field");
                    MakeAMove("PlayerOne");
                    somebodyWon = PlayerWon(playField, 'O');
                    if (somebodyWon)
                    {
                        Console.WriteLine("Congrats Player one. You are VICTORIOUS!");
                    }
                }
                else
                {
                    Console.WriteLine("Player two, pick your field");
                    MakeAMove("PlayerTwo");
                    somebodyWon = PlayerWon(playField, 'X');
                    if (somebodyWon)
                    {
                        Console.WriteLine("Congrats Player two. You are VICTORIOUS!");
                    }
                }
                
                if (turn == 9)
                {
                    Console.WriteLine("It is a tie");
                    break;
                }
            }
        }

        /// <summary>
        /// Checks if the game is won.
        /// </summary>
        /// <param name="CurrentField">The current status of the board.</param>
        /// <param name="player">the player that made the last move.</param>
        /// <returns></returns>
        static bool PlayerWon(char[,] CurrentField, char player)
        {
            // Debug statement //
            //string playerStr = player == 'O' ? "Player one" : "Player 2";
            //System.Diagnostics.Debug.WriteLine($"PlayerWon: Checking if {playerStr} won");
            if ((CurrentField[0, 0] == player && CurrentField[0, 1] == player && CurrentField[0, 2] == player) || //row 1 is the same
                (CurrentField[1, 0] == player && CurrentField[1, 1] == player && CurrentField[1, 2] == player) || //row 2 is the same
                (CurrentField[2, 0] == player && CurrentField[2, 1] == player && CurrentField[2, 2] == player) || //row 3 is the same
                (CurrentField[0, 0] == player && CurrentField[1, 0] == player && CurrentField[2, 0] == player) || //column 1 is the same
                (CurrentField[0, 1] == player && CurrentField[1, 1] == player && CurrentField[2, 1] == player) || //column 2 is the same
                (CurrentField[0, 2] == player && CurrentField[1, 2] == player && CurrentField[2, 2] == player) || //column 3 is the same
                (CurrentField[0, 0] == player && CurrentField[1, 1] == player && CurrentField[2, 2] == player) || //diag l-r is the same
                (CurrentField[0, 2] == player && CurrentField[1, 1] == player && CurrentField[2, 0] == player) )//diag r-l is the same
            {
                return true;
            }
            else
            {
                return false;
            }



    
        }
        /// <summary>
        /// Processes the move on the field. Changes the appropiate elements in the dataset.
        /// </summary>
        /// <param name="player">Player that made the move</param>
        /// <returns></returns>
        static bool MakeAMove(string player)
        {
            string input = Console.ReadLine();
            
            bool validInput = int.TryParse(input, out int numInput);
            if (validInput && numInput > 0 && numInput < 10)
            {
                //System.Diagnostics.Debug.WriteLine("MakeAMove: It is a valid input");
                for (int i = 0; i < playField.GetLength(0); i++)
                {
                    for (int j = 0; j < playField.GetLength(1); j++)
                    {
                        if (playField[i, j].Equals(char.Parse(input)))
                        {
                            playField[i, j] = player == "PlayerOne" ? 'O' : 'X';
                            turn++;
                        } 
                    }
                }
                
                return true;
            }
            else
            {
                CloseExitOrContinue(input, player);
                return false;
                
            }
        }

        /// <summary>
        /// Display the current status of the field in the console.
        /// </summary>
        /// <param name="CurrentField">2 dimensional array</param>
        static void DisplayField(char[,] CurrentField)
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

        /// <summary>
        /// Checks if it is really invalid input, or a reset/exit attempt
        /// </summary>
        /// <param name="input">User input</param>
        /// <param name="player">Player that did the input</param>
        static void CloseExitOrContinue(string input, string player)
        {
            switch (input)
            {
                case "r":
                    int counter = 0;
                    for (int i = 0; i < playField.GetLength(0); i++)
                    {
                        for (int j = 0; j < playField.GetLength(1); j++)
                        {
                            counter++;
                            playField[i, j] = char.Parse(counter.ToString());
                            System.Diagnostics.Debug.WriteLine(counter);
                        }
                    }
                    // debug statement //

                    turn = 0;
                    break;
                case "q":
                    Console.WriteLine("Thank you for playing. Have a good one today.");
                    endProgram = true;
                    break;
                default:
                    Console.WriteLine("This is not a valid input. Please try again");
                    MakeAMove(player);
                    break;
            }
        }
    }
}
