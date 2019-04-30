using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for a set of commands.
    /// </summary>
    public interface ICommandSet
    {
        /// <summary>
        /// Gets the date and time the command set was received.
        /// </summary>
        DateTime Received
        {
            get;
        }

        /// <summary>
        /// Gets the list of commands.
        /// </summary>
        IReadOnlyList<ICommand> Commands
        {
            get;
        }
    }
}
