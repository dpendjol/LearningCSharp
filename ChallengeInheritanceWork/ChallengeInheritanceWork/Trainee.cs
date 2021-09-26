using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritanceWork
{
    /*
     * Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().
     */
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee (string name, string firstname, double salary, int workinghours, int schoolhours) : base (name, firstname, salary)
        {
            this.WorkingHours = workinghours;
            this.SchoolHours = schoolhours;
        }

        public void Learn()
        {
            Console.WriteLine($"Trainee {this.Name} is learning");
        }
    }
}
