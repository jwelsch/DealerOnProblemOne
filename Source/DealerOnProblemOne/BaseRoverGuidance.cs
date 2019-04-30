using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Base implementation of rover guidance.
    /// </summary>
    public abstract class BaseRoverGuidance : IRoverGuidance
    {
        /// <summary>
        /// Gets the coordinates of the rover.
        /// </summary>
        public Point Coordinates
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets the rover's current heading.
        /// </summary>
        public Heading Heading
        {
            get;
            protected set;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected BaseRoverGuidance()
        {
        }

        /// <summary>
        /// Moves the rover.
        /// </summary>
        /// <param name="commandSet">Commands used to move the rover.</param>
        public abstract void Move(CommandSet commandSet);
    }
}
