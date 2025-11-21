using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.InputSanitisers
{
    /// <summary>
    /// A utility class for sanitizing input strings, specifically for names.
    /// </summary>
    public class StringSanitiser
    {
        /// <summary>
        /// Sanitizes the input string by capitalizing the first letter of each word.
        /// If the input is null or empty, returns "-1".
        /// </summary>
        /// <param name="input">The input string to be sanitized.</param>
        /// <returns>The sanitized string with each word capitalized, or "-1" for invalid input.</returns>
        public string SanitiseInput(string input)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(input))
            {
                return "-1"; // Return -1 for invalid input
            }

            // Trim any leading or trailing whitespace from the input
            input = input.Trim();

            // Split the input string into an array of words
            string[] words = input.Split(' ');

            // Iterate through each word in the array
            for (int i = 0; i < words.Length; i++)
            {
                // Check if the word is not empty
                if (words[i].Length > 0)
                {
                    // Capitalize the first letter of the word and convert the rest to lowercase
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            // Join the array of words back into a single string with spaces between words
            return string.Join(" ", words);
        }

        /// <summary>
        /// Method to repeatedly prompt the user for input until a valid input is received.
        /// </summary>
        /// <param name="prompt">Prompt message.</param>
        /// <returns>Valid input.</returns>
        public string GetValidInput(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                result = SanitiseInput(input);
                if (result == "-1")
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
            } while (result == "-1");

            return result; // Return the valid input
        }
    }
}