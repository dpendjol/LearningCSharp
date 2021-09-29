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
    }
}
