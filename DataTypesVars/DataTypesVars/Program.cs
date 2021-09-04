using System;

namespace DataTypesVars
{
    // Documentation about builtin data types: 
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte, can save values from -128 to 127, only whole numbers
            sbyte mySbyte = 115;
            Console.WriteLine("Type sbyte: {0}", mySbyte);
            // byte, can save values from 0 to 255, only whole numbers
            byte myByte = 128;
            Console.WriteLine("Type byte: {0}", myByte);
            // short, can save values from 32,768 to 32,767, only whole numbers
            // ushort is the unsigned version and can take values from 0 to (32,768 + 32,767), only positive numbers
            short myShort = 32000;
            Console.WriteLine("Type short: {0}", myShort);
            // int, can save values from -2,147,483,648 to 2,147,483,647, only whole numbers
            // uint is the unsigned version and follows same principle as ushort, only positive numbers
            int myInt = 32131;
            Console.WriteLine("Type int: {0}", myInt);
            // long, can save values from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807, only whole numbers
            // ulong is the unsigned version and follows same principle as ushort and uint, only positive numbers
            long myLong = -4958;
            Console.WriteLine("Type long: {0}", myLong);

            // float, has a precision of 6-9 digits, also takes negative numbers, takes floating point numbers
            // when assigning value do not forget f as suffix.
            float myFloat = 10.123455f;
            Console.WriteLine("Type float: {0}", myFloat);
            // double, has a precision of 15-17 digits, also takes negative numbers, takes floating point numbers
            // when assigning value you can use the d as suffix
            double myDouble = 11.1234123;
            Console.WriteLine("Type double: {0}", myDouble);
            // decimal, had a precision of 28-29 digits, also takes negative numbers, takes floating point numbers
            // when assigning value do not forget m as suffix
            // cannot mix with float and double in expression.
            decimal myDecimal = 123.123456123m;
            Console.WriteLine("Type decimal: {0}", myDecimal);

            // bool, can take values true or false, nothing else
            bool myBool = true;
            Console.WriteLine("Type bool: {0}", myBool);

            // char, can take a single character value; literal, Unicode value (starts with \u) or hexadecimal value (starts with \x)
            // when assigning literal value put between single quotes
            char myChar = 'a';
            Console.WriteLine("Type char: {0}", myChar);

            // string, can take a sequence of characters
            string myString = "I control text";
            Console.WriteLine("Type string: {0}", myString);
            string MySecondString = "22";
            int myStringAsInt = Int32.Parse(MySecondString);
            Console.WriteLine("String number converted to int: {0}", myStringAsInt);

        }
    }
}
