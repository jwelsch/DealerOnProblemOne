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
    }
}
