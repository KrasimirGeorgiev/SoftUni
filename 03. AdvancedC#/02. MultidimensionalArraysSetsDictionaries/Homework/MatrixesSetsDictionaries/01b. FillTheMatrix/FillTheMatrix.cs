namespace _01b.FillTheMatrix
{
    using System;
    using System.Text;

    public class FillTheMatrix
    {
        public static void Main()
        {
            int matrixRowsCols = 4;
            int[,] matrix = CreateMatrix(matrixRowsCols);
            StringBuilder matrixToStringBuilder = MatrixToStringBuilder(matrix);
            Console.WriteLine(matrixToStringBuilder.ToString());
        }

        private static int[,] CreateMatrix(int rowsCols)
        {
            int rows = rowsCols;
            int cols = rowsCols;
            int[,] matrix = new int[rows, cols];
            int counter = 1;
            bool turn = false;

            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                if (turn)
                {
                    for (int currentRow = rows - 1; currentRow >= 0; currentRow--)
                    {
                        matrix[currentRow, currentCol] = counter;
                        counter++;
                    }

                    turn = !turn;
                }
                else
                {
                    for (int currentRow = 0; currentRow < rows; currentRow++)
                    {
                        matrix[currentRow, currentCol] = counter;
                        counter++;
                    }

                    turn = !turn;
                }  
            }

            return matrix;
        }

        private static StringBuilder MatrixToStringBuilder(int[,] matrix)
        {
            StringBuilder matrixToString = new StringBuilder();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int currentElement = matrix[row, col];
                    string spacing = " ";
                    int spacingMaxLength = matrix[rows - 1, col].ToString().Length;
                    if (currentElement.ToString().Length < spacingMaxLength)
                    {
                        for (int i = 0; i < spacingMaxLength - currentElement.ToString().Length; i++)
                        {
                            spacing += " ";
                        }
                    }

                    matrixToString.Append(currentElement);
                    if (cols != cols - 1)
                    {
                        matrixToString.Append(spacing);
                    }
                }

                matrixToString.AppendLine();
            }

            return matrixToString;
        }
    }
}

// Write two programs that fill and print a matrix of size N x N.
// Filling a matrix in the regular pattern (top to bottom and left to right) is boring.
// Fill the matrix as described in both patterns below: 
// b) 
//      1 8 9  16
//      2 7 10 15
//      3 6 11 14
//      4 5 12 13