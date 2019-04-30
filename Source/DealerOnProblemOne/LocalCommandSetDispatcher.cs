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
        /// Constructor.
        /// </summary>
        /// <param name="guidance">Rover guidance to use.</param>
        public LocalCommandSetDispatcher(LocalRoverGuidance guidance)
        {
            this.guidance = guidance;
        }

        /// <summary>
        /// Dispatches commands to be executed.
        /// </summary>
        /// <param name="commandSet">Command set to dispatch.</param>
        public void Dispatch(CommandSet commandSet)
        {
            this.guidance.Move(commandSet);
        }
    }
}
