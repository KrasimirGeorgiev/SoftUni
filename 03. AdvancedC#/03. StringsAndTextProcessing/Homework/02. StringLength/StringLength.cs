namespace _02.StringLength
{
    using System;

    public class StringLength
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            int inputLength = input.Length;
            if (inputLength < 20)
            {
                Console.WriteLine(input + new string('*', 20 - inputLength));
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}

// Problem 2. String Length
// Write a program that reads from the console a string of maximum 20 characters.If the length of the string is less than 20, 
// the rest of the characters should be filled with*. Print the resulting string on the console.
