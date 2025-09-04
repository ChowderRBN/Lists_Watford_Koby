using System;
using System.Collections.Generic;

namespace Lists_Watford_Koby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a List of games
            List<string> games = new List<string>
            {
                "Life is Strange",
                "Life is Strange BTS",
                "Life is Strange 2",
                "Life is Strange TC",
                "Life is Strange DB"
            };

            // Create an array of additional games
            string[] otherGames = new string[]
            {
                "The Awesome Adventures of Captain Spirit",
                "Lost Records: Bloom & Rage",
            };

            // Print all games currently in the list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Print the count of games in the list
            Console.WriteLine($"\nGames in list: {games.Count}");

            // Add the otherGames array to the list
            games.AddRange(otherGames);

            // Print the updated count of games
            Console.WriteLine($"\nGames in list: {games.Count}");

            // Check if "Life is Strange" is in the list
            if (games.Contains("Life is Strange"))
            {
                Console.WriteLine("\nReady for the Mosh Pit, Shaka Brah");
            }
            else
            {
                // If not, add it to the list
                games.Add("Life is Strange");
            }

            int myInt = 6;

            // If index is valid, remove the game at that position
            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found! Try a hole to another universe.");
            }

            // Print all games left in the list
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sort games alphabetically
            games.Sort();

            // Print sorted games list
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Create a new array the same size as the list
            string[] newList = new string[games.Count];

            // Copy all list items into the new array
            games.CopyTo(newList);

            // Clear the original list (remove everything)
            games.Clear();

            // Print contents of the new array
            Console.WriteLine("\nNew List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
