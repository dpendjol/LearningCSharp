using System;

/*
 * Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).
 * As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
 * User If statements and User Input and Methods to solve the challenge.
 */
namespace ChallengeIfStatements
{
    class Program
    {
        // Declare class-scope vars
        static string inputUsername;
        static string inputPasswd;
        static string inputCheckpwd;
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom to the registering and loggin in system.");
            if (Register())
            {
                Console.WriteLine("Registration was a success. \nPress any key to continue...");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Registration failed. Please try again...");
            }
            if (Login())
            {
                Console.WriteLine("Login was a success");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }

        static bool Register()
        {
            Console.WriteLine("Let get you registered");
            Console.WriteLine("Please choose a username:");
            inputUsername = Console.ReadLine();
            // choose a do...while... because it has to run at least once 
            // also when the condition is not true yet
            // after 3 fails, end registration
            int i = 0;
            do
            {
                if (i > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, passwords did not match, please try again.");
                }
                i++;
                Console.WriteLine("Please choose a password:");
                inputPasswd = Console.ReadLine();
                Console.WriteLine("Please enter the chosen password again:");
                inputCheckpwd = Console.ReadLine();
            }
            while (!(inputPasswd.Equals(inputCheckpwd)) && i < 3);

            return inputPasswd.Equals(inputCheckpwd);
        }

        static bool Login()
        {
            Console.Clear();
            Console.WriteLine("When you want to log in, please enter your credentials.");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            if (!inputUsername.Equals(username))
            {
                Console.WriteLine("Sorry, this username is unknow.");
                return false;
            }
            Console.WriteLine("Password:");
            string passwd = Console.ReadLine();
            if (!inputPasswd.Equals(passwd))
            {
                Console.WriteLine("Sorry, this password is incorrect");
                return false;
            }
            return true;
        }
    }
}
