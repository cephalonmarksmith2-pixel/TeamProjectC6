using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.InputSanitisers
{
    /// <summary>
    /// A class that sanitises all Whole number inputs.
    /// </summary>
    public class InptegerSanitiser
    {
        private int _minValue;
        private int _maxValue;

        // Constructor to initialize the bounds with default values or specified values
        public InptegerSanitiser(int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        /// <summary>
        /// Method to sanitize the input and ensure it is within the specified bounds.
        /// </summary>
        /// <param name="input">Given input.</param>
        /// <returns>Sanitized input or -1 for invalid input.</returns>
        public int SanitiseInput(string input)
        {
            if (int.TryParse(input, out int result))
            {
                if (result >= _minValue && result <= _maxValue)
                {
                    return result; // Return the valid input
                }
            }
            return -1; // Return -1 for invalid input
        }

        /// <summary>
        /// Method to repeatedly prompt the user for input until a valid input is received.
        /// </summary>
        /// <param name="prompt">Prompt message.</param>
        /// <returns>Valid input.</returns>
        public int GetValidInput(string prompt)
        {
            int result;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                result = SanitiseInput(input);
                if (result == -1)
                {
                    Console.WriteLine($"Invalid input. Please enter a number between {_minValue} and {_maxValue}.");
                }
            } while (result == -1);

            return result; // Return the valid input
        }
        /// <summary>
        /// Updates the minimum and maximum bounds for input validation.
        /// </summary>
        /// <param name="minValue">The new minimum value.</param>
        /// <param name="maxValue">The new maximum value.</param>
        public void UpdateBounds(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }
    }
}