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
        /// Dispatches instructions to be executed.
        /// </summary>
        /// <param name="establishGrid">Command to establish the grid.</param>
        /// <param name="confirmPosition">Command to confirm position.</param>
        /// <param name="move">Command to move.</param>
        public void Dispatch(ICommand establishGrid, ICommand confirmPosition, ICommand move)
        {
        }
    }
}
