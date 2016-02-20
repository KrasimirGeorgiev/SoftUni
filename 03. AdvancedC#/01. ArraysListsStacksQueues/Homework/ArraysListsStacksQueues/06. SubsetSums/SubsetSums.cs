namespace _06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class SubsetSums
    {
        static void Main()
        {
            int firstSum  = 11;
            string firstTestInput = "0 11 1 10 5 6 3 4 7 2";
            //// int secondSum = 0;
            //// string secondTestInput = "1 2 3 4 5";
            //// string thirdSum = -2;
            //// string thirdTestInput = "5 4 92 0 928 1 -1 4";

            Console.WriteLine(FindSubsetSums(firstTestInput, firstSum).ToString());
        }

        private static StringBuilder FindSubsetSums(string sequence, int sum)
        {
            StringBuilder result = new StringBuilder();
            int[] sequenceSplit = sequence.Split().Select(x => int.Parse(x)).ToArray();
            HashSet<int> uniqueSequence = new HashSet<int>();
            for (int i = 0; i < sequenceSplit.Length; i++)
            {
                uniqueSequence.Add(sequenceSplit[i]);
            }

            int[] uniqueSequenceArr = uniqueSequence.ToArray();
            for (int i = 0, uniqueSequenceArrLength = uniqueSequenceArr.Length; i < uniqueSequenceArrLength; i++)
            {
                List<int> subsequence = new List<int>();
                for (int j = i; j < uniqueSequenceArrLength; j++)
                {
                    if (j == i && uniqueSequenceArr[j] == sum)
                    {
                        result.AppendLine(string.Format("{0} = {1}", uniqueSequenceArr[j], sum));
                    }
                    if (j != i && uniqueSequenceArr[i] + uniqueSequenceArr[j] == sum)
                    {
                        result.AppendLine(string.Format("{0} + {1} = {2}", uniqueSequenceArr[i], uniqueSequenceArr[j], sum));
                    }

                    subsequence.Add(uniqueSequenceArr[j]);
                    if (subsequence.Count > 2 && subsequence.Sum() == sum)
                    {
                        result.AppendLine(string.Join(" + ", subsequence) + "= " + sum);
                    }
                }
            }

            return result;
        }
    }
}
