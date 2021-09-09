using System;

namespace ChallengeJaggedArray
{
    class Program
    {
        // use jagged array's
        static void Main(string[] args)
        {
            // Piet has family members: Marie en Kees
            // Jan has family members: Bob en Samuel
            // Greet has family members: Tom en Anna

            // Introduce everybody's family

            // Then make some specific introductions
            // First introduce Marie to Samuel,
            // Then introduce Tom to Kees,
            // Finally introduce Marie to Anna

            string[][] family =
            {
                new string[] { "Piet", "Marie", "Kees", "Johan"},
                new string[] { "Jan", "Bob", "Samuel" },
                new string[] { "Greet", "Tom", "Anna"}
            };

            for (int i = 0; i < family.Length; i++)
            {
                Console.WriteLine($"Let me introduce the family of {family[i][0]}:");
                for (int j = 1; j < family[i].Length; j++)
                {
                    Console.Write($"{family[i][j]}");
                    if (j == family[i].Length - 1)
                    {
                        Console.Write("\n");
                    } else if (j == family[i].Length - 2)
                    {
                        Console.Write(" and ");
                    } else if (j < family[i].Length - 2)
                    {
                        Console.Write(", ");
                    }
                }
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine($"{family[0][1]}, let me introduce to you {family[1][2]}.");
            Console.WriteLine($"{family[2][1]}, let me introduce to you {family[0][2]}");
            Console.WriteLine($"{family[0][1]}, let me introduce to you {family[2][2]}");

            Console.ReadKey();
        }
    }
}
