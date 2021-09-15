using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritanceTryout
{
    class Cat : Animal
    {
        public string Sound { get; set; }
        public Cat(string name, int age, string sound) : base(name, age)
        {
            this.Sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.Name} makes a {this.Sound} sound.");
        }
    }
}
