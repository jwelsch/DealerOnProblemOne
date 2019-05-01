using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Dispatches a command set locally.
    /// </summary>
    public class LocalCommandSetDispatcher : ICommandSetDispatcher
    {
        /// <summary>
        /// The rover guidance logic to use.
        /// </summary>
        private readonly LocalRoverGuidance guidance;

        /// <summary>
        /// Listener to use.
        /// </summary>
        private readonly ICommandSetListener listener;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="guidance">Rover guidance to use.</param>
        /// <param name="listener">Listener to use.</param>
        public LocalCommandSetDispatcher(LocalRoverGuidance guidance, ICommandSetListener listener)
        {
            this.guidance = guidance;
            this.listener = listener;
        }

        /// <summary>
        /// Dispatches commands to be executed.
        /// </summary>
        /// <param name="commandSet">Command set to dispatch.</param>
        public void Dispatch(CommandSet commandSet)
        {
            this.guidance.Move(commandSet);

            this.listener?.Transmit($"{this.guidance.Coordinates.X} {this.guidance.Coordinates.Y} {this.guidance.Heading.ToString()[0]}");
        }
    }
}
