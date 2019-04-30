using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Represents a command to confirm position.
    /// </summary>
    public class ConfirmPositionCommand : BaseCommand
    {
        /// <summary>
        /// Gets the current x-coordinate.
        /// </summary>
        public int XCoordinate
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the current y-coordinate.
        /// </summary>
        public int YCoordinate
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the current heading.
        /// </summary>
        public char Heading
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instructions">The raw instructions of the command.</param>
        public ConfirmPositionCommand(string instructions)
            : base(instructions)
        {
        }

        /// <summary>
        /// Parses the raw instructions of the command.
        /// </summary>
        /// <param name="instructions">Raw instructions of the command.</param>
        protected override void ParseInstructions(string instructions)
        {
            var values = SplitLine(instructions, 3, ec => throw new ArgumentException($"Expected {ec} values for the confirm position command.", "instructions"));

            this.XCoordinate = ConvertToInt(values[0], "X axis length for the confirm position command could not be converted to an integer.");
            this.YCoordinate = ConvertToInt(values[1], "Y axis length for the confirm position command could not be converted to an integer.");
            this.Heading = ConvertToChar(values[2], "Heading for the confirm position command could not be converted to a string.");
        }
    }
}
