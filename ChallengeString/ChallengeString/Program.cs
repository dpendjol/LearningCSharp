using System;

namespace ChallengeString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge String 1 */
            Console.WriteLine("Challenge String - part one");

            // Declare a string variabele and don't assign a value to it
            string myName;
            // Print on the console the sentence 'Please... enter'
            Console.WriteLine("Please enter your name and press Enter:");
            // Get user input and store it in string variable you created before
            myName = Console.ReadLine();
            // write on the console that string in Uppercase
            Console.WriteLine($"This is in uppercase: {myName.ToUpper()}");
            // write string in Lowercase in the second line
            Console.WriteLine($"This is in lowercase: {myName.ToLower()}");
            // write string with no trailing or preceding white space
            Console.WriteLine($"This is without starting or trailing spaces: {myName.Trim()}");
            // write the Substring of the entered string 
            Console.WriteLine($"This is a substring starting on index 1 with a length of 3: {myName.Substring(4)}");
            
            // end of part one
            Console.WriteLine("\n End of part one, press any key to continue \n");
            Console.Read();
            Console.Clear();

            /* Challenge String 2 */
            Console.WriteLine("Challenge String - part two");
            // declare variables
            string myString;
            char searchForChar;
            string myFirstname;
            string myLastname;
            string fullName;
            // ask user to input a string
            Console.WriteLine("Enter your string here:");
            myString = Console.ReadLine();
            // ask for the character to search in the string which you have entered
            Console.WriteLine("Enter one character to search for:");
            // the char type can only contain one character. Just get the first element 
            // of the input on the commandline
            searchForChar = Console.ReadLine()[0];
            //write the index of the first occurrence of the searched character from the string
            Console.WriteLine(myString.IndexOf(searchForChar));
            //  ask to enter the first name
            Console.WriteLine("Please enter your firstname:");
            myFirstname = Console.ReadLine();
            //  ask to enter the last name
            Console.WriteLine("Please enter your lastname:");
            myLastname = Console.ReadLine();
            // try to store the full name in a variable
            fullName = $"{myFirstname} {myLastname}";
            // display the full name to the console
            Console.WriteLine(fullName);

        }
    }
}
