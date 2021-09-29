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
        private string Brand = "BMW";
        public string Model { get; set; }

        public BMW(int HP, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
    }
}
