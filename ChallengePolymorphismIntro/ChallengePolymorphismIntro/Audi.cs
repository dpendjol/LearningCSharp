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
