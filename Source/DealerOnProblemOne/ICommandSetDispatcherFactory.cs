using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Factory interface to create ICommandSetDispatcher objects.
    /// </summary>
    public interface ICommandSetDispatcherFactory
    {
        /// <summary>
        /// Creates an ICommandSetDispatcher object.
        /// </summary>
        /// <returns>The created object.</returns>
        ICommandSetDispatcher Create();
    }
}
