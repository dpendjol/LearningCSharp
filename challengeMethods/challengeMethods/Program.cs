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

            string[] names = { nameOne, nameTwo, nameThree };
            GreetMultipleFriends(names);
        }

        /// <summary>
        /// Writes a greeting to the console
        /// </summary>
        /// <param name="name">firstname of a person.</param>
        static void GreetFriend(string name)
        {
            Console.WriteLine($"Hey {name}, how are you doing?");
        }

        /// <summary>
        /// Writes greetings to console
        /// </summary>
        /// <param name="names">Pass a array of strings containing names</param>
        static void GreetMultipleFriends(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"Hey {name}, long time no see!");
            }
        }
    }
}
