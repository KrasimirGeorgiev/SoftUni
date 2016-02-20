namespace _03.CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategorizeNumbers
    {
        public static void Main()
        {
            string testInput = "1.2 -4 5.00 12211 93.003 4 2.2";
            decimal[] inputToArray = testInput.Split().Select(x => decimal.Parse(x)).ToArray();
            List<int> roundNumbers = new List<int>();
            List<decimal> nonRoundNumbers = new List<decimal>();

            for (int i = 0, testInputLength = inputToArray.Length; i < testInputLength; i++)
            {
                decimal currentNumber = inputToArray[i];
                decimal currentNumberFloatingPoint = currentNumber - (int)currentNumber;
                if (currentNumberFloatingPoint > 0)
                {
                    nonRoundNumbers.Add(inputToArray[i]);
                }
                else
                {
                    roundNumbers.Add((int)inputToArray[i]);
                }
            }

            if (nonRoundNumbers.Count > 0)
            {
                Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", nonRoundNumbers), nonRoundNumbers.Min(), nonRoundNumbers.Max(), nonRoundNumbers.Sum(), nonRoundNumbers.Average());
            }

            if (roundNumbers.Count > 0)
            {
                Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", roundNumbers), roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());
            }
        }
    }
}

// Write a program that reads N floating-point numbers from the console.
// Your task is to separate them in two sets, 
// one containing only the round numbers(e.g. 1, 1.00, etc.) 
// and the other containing the floating-point numbers with non-zero fraction.
// Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). 