using System;

namespace ChallengePolymorphismIntro
{
    class Program
    {
        // Create a base class Car with two properties HP and Color
        // Create a constructor setting those two properties
        // Create a method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair method which writes "Car was repaired" onto the console
        // Create two deriving classes, BMW and Audi, which have their own constructor and have a additional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes
        // Create the to methods ShowDetails() and Repair in them as well Adjust those methods accordingly

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Audi carone = new Audi(100, "red", "A3");
            carone.ShowDetails();
            Car cartwo = new Audi(200, "blue", "A4");
            cartwo.ShowDetails();
            carone.Drive();
            cartwo.Drive();
            

        }
    }
}
