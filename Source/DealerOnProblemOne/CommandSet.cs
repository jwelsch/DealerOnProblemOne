using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Represents a set of commands.
    /// </summary>
    public class CommandSet
    {
        /// <summary>
        /// Gets the establish grid command.
        /// </summary>
        public EstablishGridCommand EstablishGrid
        {
            get;
        }

        /// <summary>
        /// Gets the confirm position command.
        /// </summary>
        public ConfirmPositionCommand ConfirmPosition
        {
            get;
        }

        /// <summary>
        /// Gets the move command.
        /// </summary>
        public MoveCommand Move
        {
            get;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="establishGrid">The establish grid command.</param>
        /// <param name="confirmPosition">The confirm position command.</param>
        /// <param name="move">The move command.</param>
        public CommandSet(EstablishGridCommand establishGrid, ConfirmPositionCommand confirmPosition, MoveCommand move)
        {
            this.EstablishGrid = establishGrid;
            this.ConfirmPosition = confirmPosition;
            this.Move = move;
        }
    }
}
