using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Represents a command to establish a grid.
    /// </summary>
    public class EstablishGridCommand : BaseCommand
    {
        /// <summary>
        /// Gets the length of the X axis of the grid.
        /// </summary>
        public int XLength
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the length of the Y axis of the grid.
        /// </summary>
        public int YLength
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instructions">The raw instructions of the command.</param>
        public EstablishGridCommand(string instructions)
            : base(instructions)
        {
        }

        /// <summary>
        /// Parses the raw instructions of the command.
        /// </summary>
        /// <param name="instructions">Raw instructions of the command.</param>
        protected override void ParseInstructions(string instructions)
        {
            var gridValues = instructions.Split(' ');

            if (gridValues == null || gridValues.Length == 0)
            {
                throw new ArgumentException("Expected two values for the establish grid command.", "instructions");
            }

            var length = 0;

            if (!int.TryParse(gridValues[0], out length))
            {
                throw new FormatException($"X axis length for the establish grid command could not be converted to an integer.");
            }

            this.XLength = length;

            if (!int.TryParse(gridValues[1], out length))
            {
                throw new FormatException($"Y axis length for the establish grid command could not be converted to an integer.");
            }

            this.YLength = length;
        }
    }
}
