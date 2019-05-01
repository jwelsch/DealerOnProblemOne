using System;
using System.Collections.Generic;
using System.Drawing;
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
        /// Gets the position coordinates.
        /// </summary>
        public Point Coordinates
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the current heading.
        /// </summary>
        public Heading Heading
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
            string[] values;
            var count = 3;
            var x = 0;
            var y = 0;

            try
            {
                values = InstructionHelper.SplitLine(instructions, count);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Expected {count} values for the confirm position command.", nameof(instructions), ex);
            }

            try
            {
                x = InstructionHelper.ConvertToInt(values[0]);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("X axis position for the confirm position command could not be converted to an integer.", nameof(instructions), ex);
            }

            try
            {
                y = InstructionHelper.ConvertToInt(values[1]);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Y axis position for the confirm position command could not be converted to an integer.", nameof(instructions), ex);
            }

            this.Coordinates = new Point
            {
                X = x,
                Y = y
            };

            if (x < 0)
            {
                throw new ArgumentException("X axis position for the confirm position command cannot be less than zero.", nameof(instructions));
            }

            if (y < 0)
            {
                throw new ArgumentException("Y axis position for the confirm position command cannot be less than zero.", nameof(instructions));
            }

            try
            {
                this.Heading = InstructionHelper.ConvertStringToHeading(values[2]);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Heading for the confirm position command could not be converted to a string.", nameof(instructions), ex);
            }
        }
    }
}
