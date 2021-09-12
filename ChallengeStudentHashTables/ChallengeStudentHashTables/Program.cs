using System;
using System.Collections;

namespace ChallengeStudentHashTables
    /*
     * Write a program that will iterate through each element of the students array and insert them to a hashtable.
     * If a student with the same ID already exists in the hashtable skip it and display the following error:
     * "Sorry, a student with the same ID already exists".
     * hint: use the ContainKey() method to check wether a student with the same ID already exists.
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start given at start challenge
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);
            // End given at start challenge

            Hashtable table = new Hashtable();

            foreach(Student person in students)
            {
                if (!table.ContainsKey(person.ID))
                {
                    table.Add(person.ID, person);
                } else
                {
                    Console.WriteLine("!!!---!!!");
                    Console.WriteLine("Sorry, a student with the same ID already exists");
                    Console.WriteLine($"Therefore student {person.Name} is not inserted");
                    Console.WriteLine("!!!---!!!");
                }
            }

            foreach(Student person in table.Values)
            {
                Console.WriteLine($"Student with id {person.ID} is called {person.Name} and has a GPA of {person.GPA}");
            }
        }

        
    }

    // Start given at start challenge
    class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student (int ID, string name, float GPA)
        {
            this.ID = ID;
            this.Name = name;
            this.GPA = GPA;
        }
    }
    // End given at start challenge
}
