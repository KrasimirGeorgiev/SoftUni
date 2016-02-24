namespace _7.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phoneBookDictionary = new Dictionary<string, string>();

            while (input != "search")
            {
                string[] nameNumber = input.Split('-');
                string name = nameNumber[0];
                string number = nameNumber[1];
                phoneBookDictionary.Add(name, number);
                input = Console.ReadLine();
            }

            while (true)
            {
                if (input == "search")
                {
                    input = Console.ReadLine();
                }

                string inputNamePhone = string.Empty;
                if (phoneBookDictionary.TryGetValue(input, out inputNamePhone))
                {
                    Console.WriteLine("{0} -> {1}", input, inputNamePhone);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", input);
                }

                input = Console.ReadLine();
            }
        }
    }
}

// Problem 7. Phonebook
// Write a program that receives some info from the console about people and their phone numbers.
// You are free to choose the manner in which the data is entered; each entry should have just one name and one number(both of them strings). 
// After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a search of a contact by name 
// and print her details in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." 
// Test input:
// Nakov-0888080808
// search
// Mariika
// Nakov
// Nakov-+359888001122
// RoYaL(Ivan)-666
// Gero-5559393
// Simo-02/987665544
// search
// Simo
// simo
// RoYaL
// RoYaL(Ivan)
