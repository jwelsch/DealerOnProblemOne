using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Interface for rover guidance.
    /// </summary>
    public interface IRoverGuidance
    {
        /// <summary>
        /// Gets the coordinates of the rover.
        /// </summary>
        Point Coordinates
        {
            get;
        }

        /// <summary>
        /// Gets the rover's current heading.
        /// </summary>
        Heading Heading
        {
            get;
        }
        
        /// <summary>
        /// Moves the rover.
        /// </summary>
        /// <param name="commandSet">Commands used to move the rover.</param>
        void Move(CommandSet commandSet);
    }
}
