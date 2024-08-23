using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        // This method calculates the factorial of a given non-negative integer 'n'.
        // The factorial of a number n is the product of all positive integers less than or equal to n.
        // For example, the factorial of 4 (denoted as 4!) is 4 * 3 * 2 * 1 = 24.
        public static int GetFactorial(int n)
        {
            if (n < 0) throw new ArgumentException("n must be non-negative");

            return n == 0 ? 1 : n * GetFactorial(n - 1);
        }

        // This method takes an array of strings and returns a single formatted string.
        // It combines the strings with commas and the word "and" before the last item.
        // For example, ["a", "b", "c"] becomes "a, b and c".
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
