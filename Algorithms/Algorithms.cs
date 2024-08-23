using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        /// <summary>
        /// Calculates the factorial of a given non-negative integer.
        /// </summary>
        /// <param name="n">The non-negative integer for which to calculate the factorial.</param>
        /// <returns>The factorial of the input integer.</returns>
        /// <exception cref="ArgumentException">Thrown when the input integer is negative.</exception>
        public static int GetFactorial(int n)
        {
            if (n < 0) throw new ArgumentException("n must be non-negative");
            return n == 0 ? 1 : n * GetFactorial(n - 1);
        }

        /// <summary>
        /// Formats an array of strings into a single string with proper separators.
        /// </summary>
        /// <param name="items">An array of strings to format.</param>
        /// <returns>A formatted string with commas and "and" as separators.</returns>
        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            if (items.Length == 1)
                return items[0];

            return string.Join(", ", items, 0, items.Length - 1) + " and " + items[^1];
        }
    }
}
