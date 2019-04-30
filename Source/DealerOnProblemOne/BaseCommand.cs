using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Base class for individual commands.
    /// </summary>
    public abstract class BaseCommand : ICommand
    {
        /// <summary>
        /// Gets the raw instructions of the command.
        /// </summary>
        public string Instructions
        {
            get;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instructions">The raw instructions of the command.</param>
        protected BaseCommand(string instructions)
        {
            this.Instructions = instructions;

            this.ParseInstructions(this.Instructions);
        }

        /// <summary>
        /// Parses the raw instructions of the command.
        /// </summary>
        /// <param name="instructions">Raw instructions of the command.</param>
        protected abstract void ParseInstructions(string instructions);

        /// <summary>
        /// Splits an instruction line into constituent values.
        /// </summary>
        /// <param name="line">Line to split.</param>
        /// <param name="expectedCount">Number of values to expect.</param>
        /// <param name="onError">Action to invoke when an error is encountered.</param>
        /// <returns>Constituent values of the line.</returns>
        protected static string[] SplitLine(string line, int expectedCount, Action<int> onError)
        {
            var values = line.Split(' ');

            if (values == null || values.Length != expectedCount)
            {
                onError?.Invoke(expectedCount);
            }

            return values;
        }

        /// <summary>
        /// Converts a string to an integer and will throw an FormatException if conversion fails.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns>Converted integer.</returns>
        protected static int ConvertToInt(string value, string errorMessage)
        {
            var result = 0;

            if (!int.TryParse(value, out result))
            {
                throw new FormatException(errorMessage);
            }

            return result;
        }

        /// <summary>
        /// Converts a string to a heading and will throw an FormatException if conversion fails.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns>Converted integer.</returns>
        protected static Heading ConvertToHeading(string value, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 1)
            {
                throw new FormatException(errorMessage);
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
                    throw new ArgumentException($"The value {value} does not correspond to a heading.");
            }
        }
    }
}
