using System;
using System.Collections.Generic;
using System.IO;
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
        /// Interface for creating objects to dispatch a command set.
        /// </summary>
        private readonly ICommandSetDispatcherFactory dispatcherFactory;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="reader">Interface for reading a command set.</param>
        /// <param name="dispatcherFactory">Interface for creating objects to dispatch a command set.</param>
        public CommandSetInterpreter(ICommandSetReader reader, ICommandSetDispatcherFactory dispatcherFactory)
        {
            this.reader = reader;
            this.dispatcherFactory = dispatcherFactory;
        }

        /// <summary>
        /// Interpret a command set.
        /// </summary>
        public void Interpret()
        {
            // Read instruction set from where they are stored.
            var rawInstructions = reader.Read();

            // Read the individual instructions line by line.
            using (var reader = new StringReader(rawInstructions))
            {
                // Only need to read the establish grid command once, since it will be applied to all rovers.
                var line = reader.ReadLine();

                var establishGridCommand = new EstablishGridCommand(line);

                // Read as many position confirmation/movement instructions as are in the instruction set.
                while (true)
                {
                    line = reader.ReadLine();

                    // Check for end of the instructions.
                    if (line == null)
                    {
                        break;
                    }

                    var confirmPositionCommand = new ConfirmPositionCommand(line);

                    line = reader.ReadLine();

                    // Check for end of the instructions.
                    if (line == null)
                    {
                        throw new InvalidOperationException("Expected instructions for move command.");
                    }

                    var moveCommand = new MoveCommand(line);

                    var dispatcher = dispatcherFactory.Create();

                    // Dispatch the command set to a rover.
                    dispatcher.Dispatch(new CommandSet(establishGridCommand, confirmPositionCommand,  moveCommand));
                }
            }
        }
    }
}
