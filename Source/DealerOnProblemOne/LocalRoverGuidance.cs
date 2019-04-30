using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Local implementation of rover guidance.
    /// </summary>
    public class LocalRoverGuidance : BaseRoverGuidance
    {
        /// <summary>
        /// Moves the rover.
        /// </summary>
        /// <param name="commandSet">Commands used to move the rover.</param>
        public override void Move(CommandSet commandSet)
        {
            this.ValidateCommandSet(commandSet);

            this.ProcessMoves(commandSet);
        }

        /// <summary>
        /// Validate the values in the command set object.
        /// </summary>
        /// <param name="commandSet">Command set object to validate.</param>
        private void ValidateCommandSet(CommandSet commandSet)
        {
            if (commandSet.EstablishGrid == null)
            {
                throw new ArgumentException("Establish grid command was null.", nameof(commandSet));
            }

            if (commandSet.EstablishGrid.XLength < 0)
            {
                throw new ArgumentException("Establish grid command x-axis length is invalid.", nameof(commandSet));
            }

            if (commandSet.EstablishGrid.YLength < 0)
            {
                throw new ArgumentException("Establish grid command y-axis length is invalid.", nameof(commandSet));
            }

            if (commandSet.ConfirmPosition == null)
            {
                throw new ArgumentException("Confirm position command was null.", nameof(commandSet));
            }

            if (commandSet.ConfirmPosition.XCoordinate < 0)
            {
                throw new ArgumentException("Confirm position command x-coordinate value is invalid.", nameof(commandSet));
            }

            if (commandSet.ConfirmPosition.YCoordinate < 0)
            {
                throw new ArgumentException("Confirm position command y-coordinate value is invalid.", nameof(commandSet));
            }

            if (commandSet.ConfirmPosition.XCoordinate > commandSet.EstablishGrid.XLength)
            {
                throw new ArgumentOutOfRangeException("Confirm position command x-coordinate is out of the established grid.", nameof(commandSet));
            }

            if (commandSet.ConfirmPosition.YCoordinate > commandSet.EstablishGrid.YLength)
            {
                throw new ArgumentOutOfRangeException("Confirm position command y-coordinate is out of the established grid.", nameof(commandSet));
            }

            if (commandSet.Move == null)
            {
                throw new ArgumentException("Move command was null", nameof(commandSet));
            }
        }

        /// <summary>
        /// Processes the moves in the command set and updates the rover's current position and heading.
        /// </summary>
        /// <param name="commandSet">Command set containing the moves.</param>
        private void ProcessMoves(CommandSet commandSet)
        {
            this.Heading = commandSet.ConfirmPosition.Heading;
            this.XPosition = commandSet.ConfirmPosition.XCoordinate;
            this.YPosition = commandSet.ConfirmPosition.YCoordinate;

            foreach (var m in commandSet.Move.Moves)
            {
                this.Heading = HeadingCalculator.Turn(this.Heading, m);
            }
        }
    }
}
