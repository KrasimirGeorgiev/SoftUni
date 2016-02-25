namespace _06.NumberCalculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NumberCalculations
    {
        private static void Main()
        {
            int[] testSequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            double[] testSequenceTwo = { 0.1, 0.2, 0.3, 0.4, 5, 0.6, 0.6 };
            decimal[] testSequenceThree = { 0.1M, 0.1M, 0.1M };

            SequenceMinMaxAverSumProduct(testSequenceOne);
            Console.WriteLine();
            SequenceMinMaxAverSumProduct(testSequenceTwo);
            Console.WriteLine();
            SequenceMinMaxAverSumProduct(testSequenceThree);
        }

        private static void SequenceMinMaxAverSumProduct(int[] sequence)
        {
            long sum = 0;
            long product = 1;
            int min = sequence[0];
            int max = sequence[1];
            int sequenceLength = sequence.Length;

            for (int i = 0; i < sequenceLength; i++)
            {
                int currentNumber = sequence[i];
                sum += currentNumber;
                product *= currentNumber;
                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            double average = (double)sum / sequenceLength;
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine("minimum -> {0}\nmaximum -> {1}\naverage -> {2:F2}\nsum -> {3}\nproduct -> {4:F2}", min, max, average, sum, product);
        }

        private static void SequenceMinMaxAverSumProduct(double[] sequence)
        {
            double sum = 0;
            double product = 1;
            double min = sequence[0];
            double max = sequence[0];
            int sequenceLength = sequence.Length;

            for (int i = 0; i < sequenceLength; i++)
            {
                double currentNumber = sequence[i];
                sum += currentNumber;
                product *= currentNumber;
                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            double average = (double)sum / sequenceLength;
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine("minimum -> {0}\nmaximum -> {1}\naverage -> {2:F2}\nsum -> {3}\nproduct -> {4:F2}", min, max, average, sum, product);
        }

        private static void SequenceMinMaxAverSumProduct(decimal[] sequence)
        {
            decimal sum = 0;
            decimal product = 1;
            decimal min = sequence[0];
            decimal max = sequence[0];
            int sequenceLength = sequence.Length;

            for (int i = 0; i < sequenceLength; i++)
            {
                decimal currentNumber = sequence[i];
                sum += currentNumber;
                product *= currentNumber;
                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            decimal average = (decimal)sum / sequenceLength;
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine("minimum -> {0}\nmaximum -> {1}\naverage -> {2:F2}\nsum -> {3}\nproduct -> {4:F2}", min, max, average, sum, product);
        }
    }
}

// Problem 6. Number Calculations
// Write methods to calculate the minimum, maximum, average, sum and product of a given set 
// of numbers.Overload the methods to work with numbers of type double and decimal.
