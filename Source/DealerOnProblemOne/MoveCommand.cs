using System;
using System.Collections.Generic;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Represents a command to move.
    /// </summary>
    public class MoveCommand : BaseCommand
    {
        /// <summary>
        /// Gets the list of moves in the command.
        /// </summary>
        public IReadOnlyList<Movement> Moves
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="instructions">The raw instructions of the command.</param>
        public MoveCommand(string instructions)
            : base(instructions)
        {
        }

        /// <summary>
        /// Parses the raw instructions of the command.
        /// </summary>
        /// <param name="instructions">Raw instructions of the command.</param>
        protected override void ParseInstructions(string instructions)
        {
            if (instructions == null)
            {
                throw new ArgumentNullException(nameof(instructions), "The instructions cannot be null.");
            }

            var moves = new List<Movement>();

            foreach (var m in instructions)
            {
                switch (char.ToUpper(m))
                {
                    case 'L':
                        moves.Add(Movement.Left);
                        break;
                    case 'R':
                        moves.Add(Movement.Right);
                        break;
                    case 'M':
                        moves.Add(Movement.Move);
                        break;
                    default:
                        throw new ArgumentException($"The character {m} is not a valid value in the move command.", "instructions");
                }
            }

            this.Moves = moves;
        }
    }
}
