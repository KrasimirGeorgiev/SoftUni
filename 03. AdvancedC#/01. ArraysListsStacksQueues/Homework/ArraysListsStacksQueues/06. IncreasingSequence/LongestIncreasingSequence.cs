namespace _05.IncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSequence
    {
        public static void Main()
        {
            string firstTestInput = "2 3 4 1 50 2 3 4 5";
            //// string secondTestInput = "8 9 9 9 -1 5 2 3";
            //// string thirdTestInput = "1 2 3 4 5 6 7 8 9";
            //// string fourthTestInput = "5 -1 10 20 3 4";
            //// string fifthTestInput = "10 9 8 7 6 5 4 3 2 1";

            List<int[]> listOfSequences = new List<int[]>();
            listOfSequences = FindIncreasingSequences(firstTestInput);

            for (int i = 0, listOfSequencesCount = listOfSequences.Count; i < listOfSequencesCount; i++)
            {
                Console.WriteLine(string.Join(" ", listOfSequences[i]));
            }

            int maxSequenceCount = listOfSequences.Max(x => x.Length);
            for (int i = 0, listOfSequencesCount = listOfSequences.Count; i < listOfSequencesCount; i++)
            {
                if (listOfSequences[i].Length == maxSequenceCount)
                {
                    Console.WriteLine("Longest: {0}", string.Join(" ", listOfSequences[i]));
                    break;
                }
            }
        }

        private static List<int[]> FindIncreasingSequences(string input)
        {
            List<int[]> result = new List<int[]>();
            int[] inputSplit = input.Split().Select(x => int.Parse(x)).ToArray();
            List<int> sequence = new List<int>();
            int count = 1;
            for (int i = 0, inputSplitLength = inputSplit.Length; i < inputSplitLength - 1; i++)
            {
                int currentElement = inputSplit[i];
                int nextElement = inputSplit[i + 1];
                sequence.Add(currentElement);
                if (i == inputSplitLength - 2 && nextElement > currentElement)
                {
                    sequence.Add(nextElement);
                    result.Add(sequence.ToArray());
                }

                if (nextElement > currentElement)
                {
                    count++;
                }
                else
                {
                    result.Add(sequence.ToArray());
                    count = 1;
                    sequence.Clear();
                }
            }

            return result;
        }
    }
}
