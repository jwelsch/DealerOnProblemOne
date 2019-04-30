using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Reads and dispatches a command set.
    /// </summary>
    public class CommandSetInterpreter
    {
        /// <summary>
        /// Interface for reading a command set.
        /// </summary>
        private readonly ICommandSetReader reader;

        /// <summary>
        /// Interface for dispatching a command set.
        /// </summary>
        private readonly ICommandSetDispatcher dispatcher;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="reader">Interface for reading a command set.</param>
        /// <param name="dispatcher">Interface for dispatching a command set.</param>
        public CommandSetInterpreter(ICommandSetReader reader, ICommandSetDispatcher dispatcher)
        {
            this.reader = reader;
            this.dispatcher = dispatcher;
        }

        /// <summary>
        /// Interpret a command set.
        /// </summary>
        public void Interpret()
        {
            var rawInstructions = reader.Read();

            dispatcher.Dispatch(rawInstructions);
        }
    }
}
