using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritanceWork
{
    /*
     * Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().
     */
    class Employee
    {
        // properties
        private string Name { get; set; }
        private string FirstName { get; set; }
        private double Salary { get; set; }

        public Employee(string name, string firstname, double salary)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
        }
        public virtual void Work()
        {
            Console.WriteLine($"Employee {this.Name} is working.");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"Employee {this.Name} is having a break");
        }

    }
}
