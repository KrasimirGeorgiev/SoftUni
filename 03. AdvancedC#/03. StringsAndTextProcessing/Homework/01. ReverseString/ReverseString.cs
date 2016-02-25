namespace _01.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            while (true)
            {
                Console.WriteLine(ReverseStr(input));
                input = Console.ReadLine();
            }
        }

        private static string ReverseStr(string input)
        {
            char[] reverseInput = input.ToCharArray().Reverse().ToArray();
            string result = string.Join(string.Empty, reverseInput);
            return result;
        }
    }
}

// Problem 1. Reverse String
// Write a program that reads a string from the console, reverses it and prints the result back at the console.
