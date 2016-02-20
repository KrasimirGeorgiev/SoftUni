namespace _02.SelectionSort
{
    using System;
    using System.Linq;

    public class SelectionSort
    {
        public static void Main()
        {
            string firstTestInput = "6 5 4 10 -3 120 4";
            string secondTestInput = "10 9 8";

            Console.WriteLine(string.Join(" ", SortStringOfNumbersWithSelectionSort(firstTestInput)));
            Console.WriteLine(string.Join(" ", SortStringOfNumbersWithSelectionSort(secondTestInput)));
        }

        private static int[] SortStringOfNumbersWithSelectionSort(string input)
        {
            int[] sortedArr = input.Split().Select(x => int.Parse(x)).ToArray();
            int sortedArrLength = sortedArr.Length;
            for (int i = 0; i < sortedArrLength - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < sortedArrLength; j++)
                {
                    if (sortedArr[j] < sortedArr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    sortedArr[i] ^= sortedArr[min];
                    sortedArr[min] ^= sortedArr[i];
                    sortedArr[i] ^= sortedArr[min];
                }
            }

            return sortedArr;
        }
    }
}

// Write a program to sort an array of numbers and then print them back on the console.
// The numbers should be entered from the console on a single line, 
// separated by a space.Refer to the examples for problem 1.