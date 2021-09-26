﻿using System;

/*
 * Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().
 * Create a deriving class boss with the property CompanyCar and the method Lead().  Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().
 * Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
 * Don’t forget to create constructors.
 * Create an object of each of the three classes (with arbitrary values)
 * and call the methods, Lead() of Boss and Work() of Trainee.
 * 
 * Just print out the respective text, what the respective employees do.
 * E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.
 * 
 */

namespace ChallengeInheritanceWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge Inheritance Work");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Testing Employee class");
            Employee employeeOne = new Employee("Disposer", "George", 200000.00);
            employeeOne.Work();
            employeeOne.Pause();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Testing Boss class");
            Boss bossOne = new Boss("TheBoss", "Peter", 40000, true);
            bossOne.Work();
            bossOne.Pause();
            bossOne.Lead();
        }
    }
}
