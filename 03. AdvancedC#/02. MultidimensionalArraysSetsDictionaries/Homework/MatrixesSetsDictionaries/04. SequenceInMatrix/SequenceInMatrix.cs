namespace _04.SequenceInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SequenceInMatrix
    {
        private static void Main()
        {
            string[,] firstTestMatrix = 
                                        { 
                                          { "ha", "fifi", "ho", "hi" },
                                          { "fo", "ha", "hi", "xx" },
                                          { "xxx", "ho", "ha", "xx" }
                                        };
            //// string[,] secondTestMatrix = { { "s", "qq", "s"},
            ////                                { "pp", "pp", "s"},
            ////                                { "pp", "qq", "s"} };
            int matrixRows = firstTestMatrix.GetLength(0);
            int matrixCols = firstTestMatrix.GetLength(1);
            PrintMatrix(firstTestMatrix, matrixRows, matrixCols);
            List<string> result = SearchForLongestSequenceInMatrix(firstTestMatrix, matrixRows, matrixCols).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
        
        private static List<string> SearchForLongestSequenceInMatrix(string[,] matrix, int rows, int cols)
        {
            List<string> longestSequence = new List<string>();
            int longestSequenceCount = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    List<string> currentSequence = new List<string>();
                    int currentSequenceCount = 0;
                    string currentElement = matrix[row, col];
                    
                    // Searching rowDown
                    if (row != rows - 1)
                    {
                        currentSequence.Add(currentElement);
                        currentSequenceCount++;

                        for (int i = 1; i < rows - row; i++)
                        {
                            if (currentElement == matrix[row + i, col]) 
                            {
                                currentSequence.Add(matrix[row + i, col]);
                                currentSequenceCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (longestSequenceCount < currentSequenceCount)
                    {
                        longestSequence = currentSequence.ToList();
                        longestSequenceCount = currentSequenceCount;
                    }

                    currentSequenceCount = 0;
                    currentSequence.Clear();

                    // Searching colRight
                    if (col != cols - 1)
                    {
                        currentSequence.Add(currentElement);
                        currentSequenceCount++;

                        for (int i = 1; i < cols - col; i++)
                        {
                            if (currentElement == matrix[row, col + i])
                            {
                                currentSequence.Add(matrix[row, col + i]);
                                currentSequenceCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (longestSequenceCount < currentSequenceCount)
                    {
                        longestSequence = currentSequence.ToList();
                        longestSequenceCount = currentSequenceCount;
                    }

                    currentSequenceCount = 0;
                    currentSequence.Clear();

                    // Searching  upRight diagonal
                    if (col != cols - 1 && row != 0)
                    {
                        currentSequence.Add(currentElement);
                        currentSequenceCount++;
                        int min = Math.Min(rows - row, cols - col);

                        for (int i = 1; i < min; i++)
                        {
                            if (currentElement == matrix[row - i, col + i])
                            {
                                currentSequence.Add(matrix[row - i, col + i]);
                                currentSequenceCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (longestSequenceCount < currentSequenceCount)
                    {
                        longestSequence = currentSequence.ToList();
                        longestSequenceCount = currentSequenceCount;
                    }

                    currentSequenceCount = 0;
                    currentSequence.Clear();

                    // Searching  downRight diagonal
                    if (col != cols - 1 && row != rows - 1)
                    {
                        currentSequence.Add(currentElement);
                        currentSequenceCount++;
                        int min = Math.Min(rows - row, cols - col);

                        for (int i = 1; i < min; i++)
                        {
                            if (currentElement == matrix[row + i, col + i])
                            {
                                currentSequence.Add(matrix[row + i, col + i]);
                                currentSequenceCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (longestSequenceCount < currentSequenceCount)
                    {
                        longestSequence = currentSequence.ToList();
                        longestSequenceCount = currentSequenceCount;
                    }

                    currentSequenceCount = 0;
                    currentSequence.Clear();
                }
            }

            return longestSequence;
        }

        private static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            StringBuilder matrixInStrB = new StringBuilder();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrixInStrB.Append(matrix[row, col]);
                    if (col != cols - 1)
                    {
                        matrixInStrB.Append(" ");
                    }
                }

                matrixInStrB.AppendLine();
            }

            Console.WriteLine(matrixInStrB.ToString());
        }
    }
}

// Problem 4. Sequence in Matrix
//  We are given a matrix of strings of size N x M.
//  Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
//  column or diagonal.Write a program that finds the longest sequence of equal strings in the matrix.
