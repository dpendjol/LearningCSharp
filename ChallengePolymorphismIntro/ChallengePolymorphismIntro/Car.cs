using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePolymorphismIntro
{
    class Car
    {
        // property that holds the horsepower
        public int HP { get; set; }
        public string Color { get; set; }
        // property that holds the color
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"This car has {this.HP} horsepower and \n has a {this.Color} color.");
        }

        public void Repair()
        {
            Console.WriteLine($"Car was repaired");
        }
    }
}
