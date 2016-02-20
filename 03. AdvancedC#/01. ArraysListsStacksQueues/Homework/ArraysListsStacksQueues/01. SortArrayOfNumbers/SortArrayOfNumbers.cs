namespace _01.SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortArrayOfNumbers
    {
        public static void Main()
        {
            string firstTestInput = "6 5 4 10 -3 120 4";
            string secondTestInput = "10 9 8";

            Console.WriteLine(string.Join(" ", SortStringOfNumbers(firstTestInput)));
            Console.WriteLine(string.Join(" ", SortStringOfNumbers(secondTestInput)));
        }

        private static int[] SortStringOfNumbers(string input)
        {
            int[] sortedArr = input.Split().Select(x => int.Parse(x)).ToArray();
            Array.Sort(sortedArr);
            return sortedArr;
        }
    }
}

// Write a program to read an array of numbers from the console, 
// sort them and print them back on the console.
// The numbers should be entered from the console on a single line, separated by a space.
