namespace _03.LargerThanNeighbours
{
    using System;

    public class LargerThanNeighbours
    {
        private static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0, numbersLength = numbers.Length; i < numbersLength; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        private static bool IsLargerThanNeighbours(int[] numbersArr, int index)
        {
            int numbersArrLenght = numbersArr.Length;

            if (index == 0)
            {
                if (numbersArr[0] > numbersArr[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (index == numbersArrLenght - 1)
            {
                if (numbersArr[numbersArrLenght - 1] > numbersArr[numbersArrLenght - 2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (numbersArr[index] > numbersArr[index - 1] && numbersArr[index] > numbersArr[index + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

// Problem 3. Larger Than Neighbours
// Write a method that checks if the element at given position in a given array of integers 
// is larger than its two neighbours(when such exist).
