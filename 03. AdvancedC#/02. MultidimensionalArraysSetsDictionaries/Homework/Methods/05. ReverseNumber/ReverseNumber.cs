namespace _05.ReverseNumber
{
    using System;
    using System.Linq;

    public class ReverseNumber
    {
        private static void Main()
        {
            while (true)
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(ReverseFloatNumber(number));
            }
        }

        private static double ReverseFloatNumber(double number)
        {
            double result = 0;
            char[] numberToCharArr = number.ToString().ToCharArray().Reverse().ToArray();
            numberToCharArr.Reverse();
            result = double.Parse(string.Join(string.Empty, numberToCharArr));

            return result;
        }
    }
}

// Problem 5. Reverse Number
// Write a method that reverses the digits of a given floating-point number.
