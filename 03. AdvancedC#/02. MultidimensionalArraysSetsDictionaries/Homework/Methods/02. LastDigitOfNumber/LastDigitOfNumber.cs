namespace _02.LastDigitOfNumber
{
    using System;

    public class LastDigitOfNumber
    {
        private static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int lastDigit = inputNumber % 10;

            switch (lastDigit)
            {
                case 0: Console.WriteLine("zero");
                    break;
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                case 6: Console.WriteLine("six");
                    break;
                case 7: Console.WriteLine("seven");
                    break;
                case 8: Console.WriteLine("eight");
                    break;
                case 9: Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}

// Problem 2. Last Digit of Number
// Write a method that returns the last digit of a given integer as an English word.
// Test the method with different input values.Ensure you name the method properly.
