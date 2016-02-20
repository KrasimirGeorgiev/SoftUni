using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstTestInputString = "hi yes yes yes bye";
            string wordToSearch = "yes";
            Console.WriteLine(CountStringOccurances(firstTestInputString, wordToSearch));
        }
        
        private static int CountStringOccurances(string text, string pattern)
        {
            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(pattern, index)) != -1)
            {
                index += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
