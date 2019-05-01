using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for a listener of commands.
    /// </summary>
    public interface ICommandSetListener
    {
        /// <summary>
        /// Sends a message to the listener.
        /// </summary>
        /// <param name="message">Message to send.</param>
        void Transmit(string message);
    }
}
