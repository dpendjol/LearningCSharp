using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritageAnimals
{
    class Animal
    {
        // Property Name: name of the animal
        public string Name { get; set; }

        // Property: Age: age of the animal
        public int Age { get; set; }

        // Property: IsHungry: boolean stating if the animal is hungry
        public bool IsHungry { get; set; }


        // the constructor
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            // All animals just ate, so they are not hungry
            this.IsHungry = false;
        }

        // a virtual method can be overwritten in the child class
        // a 'normal' method can not.
        public virtual void MakeSound()
        {
            Console.WriteLine(this.Name + " making a sound");
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine(this.Name + " is eating.");
            }
            else
            {
                Console.WriteLine(this.Name + " is not hungry");
            }
        }

        public virtual void Play()
        {
            if (IsHungry)
            {
                Console.WriteLine(this.Name + " is hungry, do not feel like playing");
            }
            else
            {
                Console.WriteLine(this.Name + " is playing.");
            }

        }
    }
}
