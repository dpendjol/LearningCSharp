using System;

/*
 We have studied ternary operators and their usage so here is a small challenge for you. 
Let's create a small application that takes a temperature value as input and checks if the 
input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, 
however you can use if statement for the other conditions like to check if the entered value 
is a valid integer or not.


 */

namespace ChallengeTemperatureTernary
{
    class Program
    {

        static void Main(string[] args)
        {
            TemperatureCheck("aaa");
            TemperatureCheck("10");
            TemperatureCheck("20");
            TemperatureCheck("30");
               
        }

        static void TemperatureCheck(string temperature)
        {
            int numTemperature;
            bool isInt = int.TryParse(temperature, out numTemperature);
            string output = isInt ? numTemperature <= 15 ? "it is too cold": (numTemperature >= 16 && numTemperature <= 28) ? "it is ok": numTemperature > 28 ? "it is hot here" : "" : "Not a valid temperature";
            Console.WriteLine(output);        
        }
    }
}
