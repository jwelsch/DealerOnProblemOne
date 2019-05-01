using System;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Methods to help parse instructions.
    /// </summary>
    public static class InstructionHelper
    {
        /// <summary>
        /// Splits an instruction line into constituent values.
        /// </summary>
        /// <param name="line">Line to split.</param>
        /// <param name="expectedCount">Number of values to expect.</param>
        /// <returns>Constituent values of the line.</returns>
        public static string[] SplitLine(string line, int expectedCount)
        {
            var values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (values == null || values.Length != expectedCount)
            {
                throw new ArgumentException($"Expected {expectedCount} values in instruction line.");
            }

            return values;
        }

        /// <summary>
        /// Converts a string to an integer and will throw an FormatException if conversion fails.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns>Converted integer.</returns>
        public static int ConvertToInt(string value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// Converts a string to a heading and will throw an FormatException if conversion fails.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Converted integer.</returns>
        public static Heading ConvertStringToHeading(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 1)
            {
                throw new ArgumentException("Expected the string to convert to have length of 1 and be non-whitespace.", nameof(value));
            }

            var c = Char.ToUpper(Convert.ToChar(value));

            switch (c)
            {
                case 'N':
                    return Heading.North;
                case 'S':
                    return Heading.South;
                case 'E':
                    return Heading.East;
                case 'W':
                    return Heading.West;
                default:
                    throw new ArgumentException($"The value {value} does not correspond to a heading.", nameof(value));
            }
        }

        /// <summary>
        /// Converts a heading to an instruction string.
        /// </summary>
        /// <param name="heading">Heading to convert.</param>
        /// <returns>Instruction string representation.</returns>
        public static string ConvertHeadingToString(Heading heading)
        {
            return heading.ToString()[0].ToString();
        }
    }
}
