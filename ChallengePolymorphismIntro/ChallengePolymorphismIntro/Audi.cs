using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePolymorphismIntro
{
    class Audi : Car
    {
        private string brand = "Audi";

        public string Model { get; set; }

        public Audi (int hp, string color, string model) : base (hp, color)
        {
            this.Model = model;
        }

        // the new keyword hides the method of the base class

        public new void ShowDetails()
        {
            Console.WriteLine($"This {this.brand} is of the model {this.Model}, has {this.HP} horsepower and is available in the color {this.Color}.");
        }

        public new void Repair()
        {
            Console.WriteLine($"The {this.brand} {this.Model} is repaired.");
        }

        // the override keyword overrides the method of the base class
        // the sealed keyword prevents that in deriving class this method can be overriden.
        public sealed override void Drive()
        {
            Console.WriteLine($"{this.brand} drives better then a regular car.");
        }
    }
}
