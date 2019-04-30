using System;
using System.Collections.Generic;
using System.Drawing;
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
        /// Gets the size of the grid.
        /// </summary>
        public Size Grid
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
            var values = SplitLine(instructions, 2, ec => throw new ArgumentException($"Expected {ec} values for the establish grid command.", "instructions"));

            this.Grid = new Size
            {
                Width = ConvertToInt(values[0], "X axis length for the establish grid command could not be converted to an integer."),
                Height = ConvertToInt(values[1], "Y axis length for the establish grid command could not be converted to an integer.")
            };
        }
    }
}
