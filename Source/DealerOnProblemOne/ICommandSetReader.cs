using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for reading command sets.
    /// </summary>
    public interface ICommandSetReader
    {
        /// <summary>
        /// Reads the command set to a string.
        /// </summary>
        /// <returns>String containing a command set.</returns>
        string Read();
    }
}
