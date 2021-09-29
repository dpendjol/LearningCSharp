using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePolymorphismIntro
{
    class BMW : Car
    {
        // Members
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        //new keyword added because this method has to override the non-virtual method from the base class
        public new void ShowDetails()
        {
            Console.WriteLine($"This {this.brand} is of the model {this.Model}, has {this.HP} horsepower and is available in the color {this.Color}.");
        }

        public new void Repair()
        {
            Console.WriteLine($"The {this.brand} {this.Model} is repaired.");
        }
    }
}
