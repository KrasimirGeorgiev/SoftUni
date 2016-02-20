namespace _02.MaximalSum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] inputLine = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }

            int maxSum = 0;
            string possition = string.Empty;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentElement = matrix[row, col];
                    int currentSum = 0;
                    string currentPossitions = row + " " + col;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int elementFromSubMatrix = matrix[row + i, col + j];
                            currentSum += elementFromSubMatrix;
                        }
                    }

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        possition = currentPossitions;
                    }

                    currentSum = 0;
                }
            }

            int[] currentPossition = possition.Split().Select(x => int.Parse(x)).ToArray();
            int submatrixStartRow = currentPossition[0];
            int submatrixStartCol = currentPossition[1];

            Console.WriteLine();
            Console.WriteLine(maxSum);
            for (int i = submatrixStartRow; i < submatrixStartRow + 3; i++)
            {
                for (int j = submatrixStartCol; j < submatrixStartCol + 3; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}

// Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
// On the first line, you will receive the rows N and columns M.On the next N lines you will receive each row with its columns.
// Print the elements of the 3 x 3 square as a matrix, along with their sum.
