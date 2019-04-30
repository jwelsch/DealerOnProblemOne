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
        /// <param name="instructions">Instructions to be executed.</param>
        public void Dispatch(string instructions)
        {
            using (var reader = new StringReader(instructions))
            {
                var gridRaw = reader.ReadLine();

                var establishGridCommand = new EstablishGridCommand(gridRaw);
            }
        }
    }
}
