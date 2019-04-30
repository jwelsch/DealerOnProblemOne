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
            var rawInstructions = reader.Read();

            using (var reader = new StringReader(rawInstructions))
            {
                var line = reader.ReadLine();

                var establishGridCommand = new EstablishGridCommand(line);

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

                    var moveCommand = new MoveCommand(line);

                    var dispatcher = dispatcherFactory.Create();

                    dispatcher.Dispatch(establishGridCommand, confirmPositionCommand, moveCommand);
                }
            }
        }
    }
}
