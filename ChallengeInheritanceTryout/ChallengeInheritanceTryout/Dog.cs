using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritanceTryout
{
    class Dog : Animal
    {
        // constructor uses constructor of Animal class
        public Dog(string name, int age) : base(name, age)
        {

        }

        // method Eat from base class is overwritten
        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is eating from own class");
        }
    }
}
