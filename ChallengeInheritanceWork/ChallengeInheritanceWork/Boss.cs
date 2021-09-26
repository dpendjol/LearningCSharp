using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritanceWork
{
    /*
     * Create a deriving class boss with the property CompanyCar and the method Lead().  
     */
    class Boss : Employee
    {
        public bool CompanyCar { get; set; }

        public Boss (string name, string firstname, double salary, bool companycar) : base (name, firstname, salary)
        {
            this.CompanyCar = companycar;
        }

        public void Lead()
        {
            Console.WriteLine("Leading");
        }

        public override void Work()
        {
            Console.WriteLine("The bossman is working !");
        }
    }
}
