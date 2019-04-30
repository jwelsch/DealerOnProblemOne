using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IReadOnlyList<char> Moves
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
            var moves = new List<char>();

            foreach (var m in instructions)
            {
                var M = char.ToUpper(m);

                if (M != 'L' && M != 'R' && M != 'M')
                {
                    throw new ArgumentException($"The character {m} is not a valid value in the move command.", "instructions");
                }

                moves.Add(M);
            }

            this.Moves = moves;
        }
    }
}
