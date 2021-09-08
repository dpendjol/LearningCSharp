using System;

namespace ChallengeBoxProperties
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BoxProperties");
            Box myBox = new Box();
            myBox.Width = 2;
            myBox.Length = 2;
            myBox.height = 2;
            Console.WriteLine("The volume of the box is: " + myBox.Volume);
            myBox.Length = -4;
            Console.WriteLine("The volume of the box is now: " + myBox.Volume);
        }


    }
}
