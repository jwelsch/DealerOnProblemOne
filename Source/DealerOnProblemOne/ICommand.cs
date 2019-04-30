using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for an individual command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets the raw instructions of the command.
        /// </summary>
        string Instructions
        {
            get;
        }
    }
}
