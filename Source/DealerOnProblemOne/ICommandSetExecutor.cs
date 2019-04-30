using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for executing a set of commands.
    /// </summary>
    public interface ICommandSetExecutor
    {
        /// <summary>
        /// Executes the command set.
        /// </summary>
        void Execute();
    }
}
