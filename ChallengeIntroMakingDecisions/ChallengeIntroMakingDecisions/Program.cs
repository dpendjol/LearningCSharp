using System;

namespace ChallengeIntroMakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Help with choosing what to were given a temperature.
            Console.WriteLine("Please enter the current temperature in Celsius:");
            string Temp = Console.ReadLine();
            try
            {
                // Parse a number from the string. Can also use Int32.Parse
                int numTemp = int.Parse(Temp);
                if (numTemp < 0)
                {
                    Console.WriteLine("It is freezing, stay inside !!");
                // use of else if is more efficient then seperate if statements.
                } else if (numTemp >= 0 && numTemp < 10)
                {
                    Console.WriteLine("It is very cold, when you go outside, dress warm!");
                } else if (numTemp >= 10 && numTemp < 20)
                {
                    Console.WriteLine("It chilly outside, don't forget your coat.");
                } else if (numTemp >= 20 && numTemp < 30)
                {
                    Console.WriteLine("It is nice outside, pants and a shirt are more then enough!");
                } else if (numTemp >=30 && numTemp < 40)
                {
                    Console.WriteLine("It is hot outside, even shorts and a shirt are to much.");
                } else
                {
                    Console.WriteLine("It is so hot, better stay inside to prevent melting away.");
                }

            }
            // When user input is something else then a number
            catch (FormatException)
            {
                Console.WriteLine("FormatException: next time please enter a number");
            }
            // When user input is too large or too small
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: it can't be that hot or cold");
            }
            // When user input remains empty (null)
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException: next time please enter a number, can't leave it empty");
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
