namespace _03.CountSubstringOccurrences
{
    using System;
    using System.Text.RegularExpressions;

    public class CountSubstringOccurrences
    {
        private static void Main()
        {
            string text = "aaaaaa";
            string substring = "aa";
            //// string text = "Welcome to the Software University (SoftUni)!Welcome to programming.Programming is wellness for developers, said Maxwell.";
            //// string substring = "wel";
            //// string text = "ababa caba";
            //// string substring = "aba";
            //// string text = "Welcome to SoftUni";
            //// string substring = "Java";

            //// char[] textToCharArr = text.ToCharArray().Select(x => char.ToLower(x)).ToArray();
            //// text = string.Join(string.Empty, textToCharArr);
            //// int countSubstrInText = Regex.Matches(text, substring).Count; // -> this works without overlapping and is Case Sensitive
            Console.WriteLine(CountSubstringOccursInText(text, substring));
        }

        private static int CountSubstringOccursInText(string text, string substring)
        {
            int occurrencesCount = 0;
            int textLength = text.Length;
            int substringLength = substring.Length;

            for (int i = 0; i < textLength - (substringLength - 1); i++)
            {
                for (int j = 0; j < substringLength; j++)
                {
                    if (char.ToLower(text[i + j]) != char.ToLower(substring[j]))
                    {
                        break;
                    }

                    if (j == substringLength - 1 && char.ToLower(text[i + j]) == char.ToLower(substring[j]))
                    {
                        occurrencesCount++;
                    }
                }
            }

            return occurrencesCount;
        }
    }
}

// Problem 3. Count Substring Occurrences
// Write a program to find how many times a given string appears in a given text as substring.The text is given at the first input line.
// The search string is given at the second input line. The
// output is an integer number.Please ignore the character casing.Overlapping between occurrences is allowed.