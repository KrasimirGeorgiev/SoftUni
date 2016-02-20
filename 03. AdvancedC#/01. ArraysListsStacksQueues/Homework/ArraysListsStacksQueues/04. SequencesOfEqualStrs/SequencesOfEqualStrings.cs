namespace _04.SequencesOfEqualStrs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
    public class SequencesOfEqualStrings
    {
        public static void Main()
        {
            string firstTestInput = "hi yes yes yes bye";
            //// string secondTestInput = "SoftUni softUni softuni";
            //// string thirdTestInput = "1 1 2 2 3 3 4 4 5 5";
            //// string fourthTestInput = "a b b xxx c c c";
            //// string fifthTestInput = "hi hi hi hi hi";
            //// string sixthTestInput = "hello";

            PrintAllStringOccurrances(firstTestInput);
            //// PrintAllStringOccurrances(secondTestInput);
            //// PrintAllStringOccurrances(thirdTestInput);
            //// PrintAllStringOccurrances(fourthTestInput);
            //// PrintAllStringOccurrances(fifthTestInput);
            //// PrintAllStringOccurrances(sixthTestInput);
        }

        private static int CountStringOccurrances(string text, string pattern)
        {
            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(pattern, index)) != -1)
            {
                index += pattern.Length;
                count++;
            }

            return count;
        }

        private static void PrintAllStringOccurrances(string text)
        {
            Dictionary<string, int> stringsCount = new Dictionary<string, int>();
            string str = text;
            string[] strToArr = str.Split().ToArray();
            HashSet<string> uniqueSubstringsInText = new HashSet<string>();
            for (int i = 0, arrLength = strToArr.Length; i < arrLength; i++)
            {
                uniqueSubstringsInText.Add(strToArr[i]);
            }

            foreach (string element in uniqueSubstringsInText)
            {
                int count = CountStringOccurrances(text, element);
                for (int i = 0; i < count; i++)
                {
                    Console.Write(element);
                    if (i != count - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

// Write a program that reads an array of strings and finds in it all sequences of equal elements(comparison should be case-sensitive). 
// The input strings are given as a single line, separated by a space. 