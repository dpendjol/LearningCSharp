using System;

namespace ChallengeStudentAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            int entries = 0;
            string input = "";
            float lastGrade = 0f;

            while (input != "-1")
            {
                Console.Clear();
                Console.WriteLine("Calculate average.");
                Console.WriteLine("Number of entries: " + entries);
                Console.WriteLine("Last grade entered: " + lastGrade);
                Console.WriteLine("Please enter a grade between 0 and 20");
                input = Console.ReadLine();

                if (float.TryParse(input, out float inputNum) && inputNum > 0 && inputNum <= 20)
                {
                    lastGrade = inputNum;
                    sum += inputNum;
                    entries++;
                } else
                {
                    if (!input.Equals("-1"))
                    {
                        Console.WriteLine("Error, input is not a number, of a number not between 0 and 20.");
                        Console.WriteLine("Press any key to try again.");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The average from " + entries + " entries is: " + (sum / entries));
            Console.ReadKey();
        }
    }   
}

