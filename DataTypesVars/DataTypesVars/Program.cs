using System;

namespace DataTypesVars
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 20.12345567f;
            double myDouble = 20.1234567890;
            decimal myDecimal = 20.12314567890123M;
            bool myBool = true;
            sbyte mySbyte = 115;
            short myShort = 256;
            int myInt = 23;
            long myLong = 123149823;
            char myChar = 'a';
            string myString;
            string myString2;

            myString = "I control text";
            myString2 = "23";
            myInt = Int32.Parse(myString2);

            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myBool);
            Console.WriteLine(mySbyte);
            Console.WriteLine(myShort);
            Console.WriteLine(myInt);
            Console.WriteLine(myLong);
            Console.WriteLine(myChar);
            Console.WriteLine(myString);
            Console.WriteLine(myString2);

        }
    }
}
