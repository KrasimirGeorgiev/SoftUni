namespace _05.UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        private static void Main()
        {
            string firstTestInput = "Hi!";
            StringBuilder result = new StringBuilder();
            //// string secondTestInput = "What ? !?";
            //// string thirdTestInput = "SoftUni";
            for (int i = 0; i < firstTestInput.Length; i++)
            {
                int charToUtf = char.ConvertToUtf32(firstTestInput, i);
                string charToUtfToStr = charToUtf.ToString();
                if (charToUtfToStr.Length < 4)
                {
                    charToUtfToStr = new string('0', 4 - charToUtfToStr.Length) + charToUtfToStr;
                }

                result.Append("\\u" + charToUtfToStr);
            }

            Console.WriteLine(result.ToString());
        }
    }
}

// Problem 5. Unicode Characters
// Write a program that converts a string to a sequence of C# Unicode character literals. 
