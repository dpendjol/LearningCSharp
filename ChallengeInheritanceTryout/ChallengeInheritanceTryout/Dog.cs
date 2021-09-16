using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritanceTryout
{
    class Dog : Animal
    {

        public bool IsHappy { get; set; }
        // constructor uses constructor of Animal class
        public Dog(string name, int age) : base(name, age)
        {
            this.IsHappy = true;
        }

        // method Eat from base class is overwritten
        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is eating from own class");
        }

        public override void Play()
        {
            if (this.IsHappy)
            {
                base.Play();
            } else
            {
                Console.WriteLine($"{this.Name} is not happy... Therefore not playing.");
            }
        }

        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
