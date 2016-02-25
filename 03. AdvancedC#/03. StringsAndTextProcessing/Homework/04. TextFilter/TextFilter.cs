namespace _04.TextFilter
{
    using System;
    using System.Text.RegularExpressions;

    public class TextFilter
    {
        private static void Main()
        {
            string bannedWords = "Linux, Windows";
            string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
            string[] arrOfBannedWords = bannedWords.Split(new string[] { ", " }, StringSplitOptions.None);
            //// string[] arrOfBannedWords = Regex.Split(bannedWords, ", "); // -> Regex split

            Console.WriteLine(FilterText(text, arrOfBannedWords));
        }

        private static string FilterText(string text, string[] bannedWords)
        {
            int bannedWordsLength = bannedWords.Length;

            for (int i = 0; i < bannedWordsLength; i++)
            {
                string currentBannedWord = bannedWords[i];
                int currentBannedWordLength = currentBannedWord.Length;
                while (text.Contains(currentBannedWord))
                {
                    int index = text.IndexOf(currentBannedWord);
                    text = text.Remove(index, currentBannedWordLength);
                    text = text.Insert(index, new string('*', currentBannedWordLength));
                }
            }

            return text;
        }
    }
}

// Problem 4. Text Filter
// Write a program that takes a text and a string of banned words.All words included in the ban list should be replaced with asterisks "*", 
// equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
// The ban list should be entered on the first input line and the text on the second input line.
