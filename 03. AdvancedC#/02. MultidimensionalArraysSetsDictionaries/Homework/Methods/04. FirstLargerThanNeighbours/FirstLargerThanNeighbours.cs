namespace _04.FirstLargerThanNeighbours
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FirstLargerThanNeighbours
    {
        private static void Main()
        {
            int[] testSequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] testSequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] testSequenceThree = { 1, 1, 1 };

            Console.WriteLine(IsLargerThanNeighbours(testSequenceOne));  
        }

        private static int IsLargerThanNeighbours(int[] numbersArr)
        {
            for (int index = 0, numbersArrLength = numbersArr.Length; index < numbersArrLength; index++)
            {
                int numbersArrLenght = numbersArr.Length;

                if (index == 0)
                {
                    if (numbersArr[0] > numbersArr[1])
                    {
                        return index;
                    }
                }
                else if (index == numbersArrLenght - 1)
                {
                    if (numbersArr[numbersArrLenght - 1] > numbersArr[numbersArrLenght - 2])
                    {
                        return index;
                    }
                }
                else
                {
                    if (numbersArr[index] > numbersArr[index - 1] && numbersArr[index] > numbersArr[index + 1])
                    {
                        return index;
                    }
                }
            }

            return -1;
        }
    }
}

// Problem 4. First Larger Than Neighbours
// Write a method that returns the index of the first element in array that is larger than 
// its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.
