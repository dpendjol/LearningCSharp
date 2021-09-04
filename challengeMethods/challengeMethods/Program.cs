using System;

namespace challengeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 3 variables which contain names
            string nameOne = "Frank";
            string nameTwo = "Henk";
            string nameThree = "Piet";
            
            // Call the method GreetFriend
            GreetFriend(nameOne);
            GreetFriend(nameTwo);
            GreetFriend(nameThree);
        }

        /// <summary>
        /// Writes a greeting to the console
        /// </summary>
        /// <param name="name">firstname of a person.</param>
        static void GreetFriend(string name)
        {
            Console.WriteLine($"Hey {name}, how are you doing?");
        }
    }
}
