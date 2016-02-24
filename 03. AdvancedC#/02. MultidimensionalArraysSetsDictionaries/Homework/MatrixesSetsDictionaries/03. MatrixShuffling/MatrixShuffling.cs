namespace _03.MatrixShuffling
{
    using System;
    using System.Linq;
    using System.Text;

    public class MatrixShuffling
    {
        private static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputSplit = input.Split();
                if (inputSplit[0] != "swap" || inputSplit.Length != 5 || 
                    int.Parse(inputSplit[1]) >= rows || int.Parse(inputSplit[3]) >= rows || 
                    int.Parse(inputSplit[2]) >= cols || int.Parse(inputSplit[4]) >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                string firstRowCol = inputSplit[1] + " " + inputSplit[2];
                string secondRowCol = inputSplit[3] + " " + inputSplit[4];
                SwapPositionsInMatrix(matrix, firstRowCol, secondRowCol);
                PrintMatrix(matrix, rows, cols);
                input = Console.ReadLine();
            }
        }

        private static void SwapPositionsInMatrix(string[,] matrix, string firstPositionRowCol, string secondPostionRowCol)
        {
            int[] firstRowCol = firstPositionRowCol.Split().Select(int.Parse).ToArray();
            int firstRow = firstRowCol[0];
            int firstCol = firstRowCol[1];
            int[] secondRowCol = secondPostionRowCol.Split().Select(int.Parse).ToArray();
            int secondRow = secondRowCol[0];
            int secondCol = secondRowCol[1];
            string firstPostition = matrix[firstRow, firstCol];
            matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
            matrix[secondRow, secondCol] = firstPostition;
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

// Problem 3. Matrix shuffling
//  Write a program which reads a string matrix from the console and performs certain operations with its elements.
//  User input is provided in a similar way like in the problem above – first you read the dimensions and then the data.
//  Remember, you are not required to do this step first, you may add this functionality later.  
//  Your program should then receive commands in format: "swap row1 col1 row2c col2" where row1, row2, col1, col2 are coordinates in the matrix. 
//  In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). 
//  You should swap the values at the given coordinates(cell[row1, col1] with cell[row2, col2]) and print the matrix 
//  at each step(thus you'll be able to check if the operation was performed correctly). 
//  If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), 
//  print "Invalid input!" and move on to the next command. 
//  Your program should finish when the string "END" is entered. 