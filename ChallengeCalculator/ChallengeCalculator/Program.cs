using System;

namespace ChallengeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // What does this do
            Console.WriteLine("We are going to add a two numbers");
            Console.WriteLine("Please insert the first number");
            string numberOne = Console.ReadLine();
            Console.WriteLine("Please insert another number");
            string numberTwo = Console.ReadLine();

            // try to execute the 'try' codeblock, when a error occurs,
            // switch to the catch codeblock to handle the error, in this case
            // display a message to the user
            // finaly a Console.Read() to prevent the window from closing automatically
            try
            {
                int numberOneInt = int.Parse(numberOne);
                int numberTwoInt = int.Parse(numberTwo);
                int[] all = { numberOneInt, numberTwoInt };
                Console.WriteLine("Numbers added give: {0}", Add(all));
                Console.WriteLine("Numbers divided give: {0}", Divide(numberOneInt, numberTwoInt));
            }

            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter a whole number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, number is either too large or too small");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null exception, please enter a number, the input seems to be empty");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception, not sure wat, but something whent wrong");
            }
            finally
            {
                Console.Read();
            }
        }

        /// <summary>
        /// adds integers together
        /// </summary>
        /// <param name="numbers">array of integers</param>
        /// <returns>Sum of array as integer</returns>
        static int Add(int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }


        /// <summary>
        /// Divide 2 numbers
        /// </summary>
        /// <param name="numberOne">the dividend</param>
        /// <param name="numberTwo">the divisor</param>
        /// <returns></returns>
        static double Divide(double numberOne, double numberTwo)
        {
            double result;

            try
            {
                result = numberOne / numberTwo;
                // check if there was a division by zero.
                // due to inaccuracy the double is not exactly 0, by really small.
                // therefore the division results in a number that approaches infinity
                // also when using doubles or decimals, the DivisionByZero exception does not occur so it seems
                if (double.IsInfinity(result))
                {
                    Console.WriteLine("Division by zero error");
                    return -1
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something whent wrong while dividing.");
                return -1;
            }
            return result;
        }

    }
}
