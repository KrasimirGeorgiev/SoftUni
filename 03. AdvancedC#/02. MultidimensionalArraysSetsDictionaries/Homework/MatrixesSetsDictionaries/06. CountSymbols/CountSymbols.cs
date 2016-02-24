namespace _06.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbols
    {
        private static void Main()
        {
            string firstTestInput = "SoftUni rocks";
            //// string secondTestInput = "Did you know Math.Round rounds to the nearest even integer?";
            //// string thirdTestInput = "Uvh34yt78y78y7Y&T^^DFt362t62thfwuihhYG&GY2";
            char[] symbolsArr = firstTestInput.ToCharArray();
            List<int> uniqueSymbolsList = symbolsArr.Distinct().Select(x => x * 1).ToList();
            uniqueSymbolsList.Sort();

            foreach (var number in uniqueSymbolsList)
            {
                char currentSymbol = (char)number;
                int currentCount = symbolsArr.Count(x => x == currentSymbol);
                Console.WriteLine("{0}: {1} time/s", currentSymbol.ToString(), currentCount);
            }
        }
    }
}

// Problem 6. Count Symbols
// Write a program that reads some text from the console and counts the occurrences of each character in it.
// Print the results in alphabetical(lexicographical) order.