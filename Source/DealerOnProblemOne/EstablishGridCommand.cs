using System;
using System.Drawing;

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
            string[] values;
            var count = 2;
            var w = 0;
            var h = 0;

            try
            {
                values = InstructionHelper.SplitLine(instructions, count);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Expected {count} values for the establish grid command.", nameof(instructions), ex);
            }

            try
            {
                w = InstructionHelper.ConvertToInt(values[0]);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("X axis length for the establish grid command could not be converted to an integer.", nameof(instructions), ex);
            }

            try
            {
                h = InstructionHelper.ConvertToInt(values[1]);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Y axis length for the establish grid command could not be converted to an integer.", nameof(instructions), ex);
            }

            if (w < 0)
            {
                throw new ArgumentException("X axis length for the establish grid command cannot be less than zero.", nameof(instructions));
            }

            if (h < 0)
            {
                throw new ArgumentException("Y axis length for the establish grid command cannot be less than zero.", nameof(instructions));
            }

            this.Grid = new Size
            {
                Width = w,
                Height = h
            };
        }
    }
}
