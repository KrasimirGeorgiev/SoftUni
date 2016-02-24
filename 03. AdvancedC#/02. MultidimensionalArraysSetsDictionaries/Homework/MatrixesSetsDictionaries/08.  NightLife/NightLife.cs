namespace _08.NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NightLife
    {
        private static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> result = new Dictionary<string, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputSplit = input.Split(';');
                string city = inputSplit[0];
                string venue = inputSplit[1];
                string performer = inputSplit[2];

                result.Add(city, new Dictionary<string, List<string>>());

                input = Console.ReadLine();
            }
        }
    }
}

// Problem 8. Night Life
// Being a nerd means writing programs about night clubs instead of actually going to ones.
// Spiro is a nerd and he decided to summarize some info about the most popular night clubs around the world.
// He's come up with the following structure – he'll summarize the data by city, where each city will have a list of 
// venues and each venue will have a list of performers. Help him finish the program, so he can stop staring at 
// the computer screen and go get himself a cold beer.
// You'll receive the input from the console. There will be an arbitrary number of lines until you receive the string "END". 
// Each line will contain data in format: "city;venue;performer". If either city, venue or performer don't exist yet in the database, 
// add them. If either the city and/or venue already exist, update their info.
// Cities should remain in the order in which they were added, venues should be sorted alphabetically and performers should be unique (per venue) and also sorted alphabetically.
// Print the data by listing the cities and for each city its venues (on a new line starting with "->") and performers(separated by comma and space).