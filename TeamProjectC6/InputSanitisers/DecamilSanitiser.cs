using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.InputSanitisers
{
    /// <summary>
    /// A class to sanitize all decimil inputs eg 1.5
    /// </summary>
    public class DecamilSanitiser
    {
        private decimal _minValue;
        private decimal _maxValue;

        // Constructor to initialize the bounds with default values or specified values
        public DecamilSanitiser(decimal minValue = decimal.MinValue, decimal maxValue = decimal.MaxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        /// <summary>
        /// Method to sanitize the input and ensure it is within the specified bounds.
        /// </summary>
        /// <param name="input">Given input.</param>
        /// <returns>Sanitized input or -1 for invalid input.</returns>
        public decimal SanitiseInput(string input)
        {
            if (decimal.TryParse(input, out decimal result))
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
        public decimal GetValidInput(string prompt)
        {
            decimal result;
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
    }
}