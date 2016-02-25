namespace _06.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        private static void Main()
        {
            List<string> palindromes = new List<string>();
            string inputText = "Hi,exe? ABBA! Hog fully a string. Bob";
            palindromes = FindPalindromesInText(inputText).ToList();

            Console.WriteLine(string.Join(" ", palindromes));
        }

        private static List<string> FindPalindromesInText(string text)
        {
            List<string> palindromes = new List<string>();
            string[] testToArr = text.Split(new char[] { ' ', ',', '.', '!', '?', ';', '"', '\'', '/', ':' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0, testToArrLength = testToArr.Length; i < testToArrLength; i++)
            {
                string currentWord = testToArr[i];
                string currentWordReversed = string.Join(string.Empty, currentWord.ToCharArray().Reverse());
                if (currentWord == currentWordReversed)
                {
                    palindromes.Add(currentWord);
                }
            }

            palindromes.Sort();
            return palindromes;
        }
    }
}

// Problem 6. Palindromes
// Write a program that extracts from a given text all palindromes, e.g.ABBA, lamal, exe and prints them on the console on a single line, 
// separated by comma and space.Use spaces, commas, dots, question marks and exclamation marks as word delimiters.Print only unique palindromes,
// sorted lexicographically.
