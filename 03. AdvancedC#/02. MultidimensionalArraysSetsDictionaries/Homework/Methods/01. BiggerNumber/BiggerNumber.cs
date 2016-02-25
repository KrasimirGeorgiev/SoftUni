namespace _01.BiggerNumber
{
    using System;

    public class BiggerNumber
    {
        private static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstNumber, secondNumber));
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        } 
    }
}

// Problem 1. Bigger Number
// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 2 integers from the console and prints the largest of them 
// using the method GetMax().
