using System;

namespace ChallengeInheritanceTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog kees = new Dog("Pietje", 23);
            kees.Eat();
            kees.Play();
            kees.MakeSound();

            Cat snotje = new Cat("Snotje", 50, "Miauwww");
            snotje.MakeSound();
            kees.IsHappy = false;
            kees.Play();
        }
    }
}
