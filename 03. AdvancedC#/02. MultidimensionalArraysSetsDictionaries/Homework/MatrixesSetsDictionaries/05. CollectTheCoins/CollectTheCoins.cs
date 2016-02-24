namespace _05.CollectTheCoins
{
    using System;

    public class CollectTheCoins
    {
        private static void Main()
        {
            char[][] jagged = new char[4][];
            int coinsCollected = 0;
            int wallsHit = 0;
            for (int i = 0; i < 4; i++)
            {
                string jaggedArrInputLine = Console.ReadLine();
                int jaggedArrInputLineLength = jaggedArrInputLine.Length;
                jagged[i] = new char[jaggedArrInputLineLength];
                for (int j = 0; j < jaggedArrInputLineLength; j++)
                {
                    jagged[i][j] = jaggedArrInputLine[j];
                }
            }

            char[] moves = Console.ReadLine().ToCharArray();
            int currentRowPosition = 0;
            int currentColPosition = 0;
            for (int i = 0, movesLength = moves.Length; i < movesLength; i++)
            {
                char currentChar = moves[i];
                switch (currentChar)
                {
                    case 'V':
                        if (currentRowPosition + 1 >= 4 || currentColPosition >= jagged[currentRowPosition + 1].Length)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            currentRowPosition++;
                            if (jagged[currentRowPosition][currentColPosition] == '$')
                            {
                                coinsCollected++;
                            }
                        }

                        break;
                    case '<':
                        if (currentColPosition - 1 < 0)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            currentColPosition--;
                            if (jagged[currentRowPosition][currentColPosition] == '$')
                            {
                                coinsCollected++;
                            }
                        }

                        break;
                    case '>':
                        if (currentColPosition + 1 >= jagged[currentRowPosition].Length)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            currentColPosition++;
                            if (jagged[currentRowPosition][currentColPosition] == '$')
                            {
                                coinsCollected++;
                            }
                        }

                        break;
                    case '^':
                        if (currentRowPosition - 1 < 0 || currentColPosition >= jagged[currentRowPosition - 1].Length)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            currentRowPosition--;
                            if (jagged[currentRowPosition][currentColPosition] == '$')
                            {
                                coinsCollected++;
                            }
                        }

                        break;
                }
            }

            Console.WriteLine("Coins collected: {0}", coinsCollected);
            Console.WriteLine("Walls hit: {0}", wallsHit);
        }
    }
}

// Problem 5. Collect the Coins
// Working with multidimensional arrays can be(and should be) fun.Let's make a game out of it.
// You receive the layout of a board from the console.Assume it will always have 4 rows which you'll get as strings, each on a separate line. 
// Each character in the strings will represent a cell on the board. Note that the strings may be of different length.
// You are the player and start at the top-left corner (that would be position [0, 0] on the board). 
// On the fifth line of input you'll receive a string with movement commands which tell you where to go next, 
// it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). 
// You need to keep track of two types of events – collecting coins(represented by the symbol '$', of course) and hitting the walls of the board
// (when the player tries to move off the board to invalid coordinates). 
// When all moves are over, print the amount of money collected and the number of walls hit.
