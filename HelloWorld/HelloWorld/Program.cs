using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            string myinput = Console.ReadLine();
            string[] mystrings = { "string 1", "string 2", "string 3" };
            Console.WriteLine("I've inputted the following: {0}. {1}", mystrings);

            int myAscii = Console.Read();
            Console.WriteLine("I have pressed " + myAscii);

            Console.ReadKey();
            */
            Test();
            Program2.Test2();
        }

        static void Test()
        {
            Console.WriteLine("this is the test method");
        }
    }

    class Program2
    {

        public static void Test2()
        {
            Console.WriteLine("This is program2.main");
        }
       
    }
}
