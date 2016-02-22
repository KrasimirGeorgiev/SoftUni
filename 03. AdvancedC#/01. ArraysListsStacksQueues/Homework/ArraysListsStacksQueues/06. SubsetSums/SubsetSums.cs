namespace _06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class SubsetSums
    {
        private static int _sumOfNumbers;
        private static List<int> _numbers;
        private static bool _thereIsResult;

        private static void Main()
        {
            int firstSum  = 11;
            string firstTestInput = "0 11 1 10 5 6 3 4 7 2";
            _sumOfNumbers = firstSum;
            _numbers = firstTestInput.Split().Select(int.Parse).Distinct().ToList();
            //// int secondSum = 0;
            //// string secondTestInput = "1 2 3 4 5";
            //// string thirdSum = -2;
            //// string thirdTestInput = "5 4 92 0 928 1 -1 4";
            List<int> subset = new List<int>();
            CalculateSubset(0, subset);
            if (!_thereIsResult)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        private static void CalculateSubset(int startingIndex, List<int> numbersForSum)
        {
            if (numbersForSum.Count > 0 && numbersForSum.Sum() == _sumOfNumbers)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", numbersForSum), _sumOfNumbers);
                _thereIsResult = true;
            }

            for (int index = startingIndex; index < _numbers.Count; index++)
            {
                numbersForSum.Add(_numbers[index]);
                CalculateSubset(index + 1, numbersForSum);
                numbersForSum.RemoveAt(numbersForSum.Count - 1);
            }
        }
    }
}



