using System.Collections.Generic;

namespace DealerOnProblemOne
{
    /// <summary>
    /// Calculates headings.
    /// </summary>
    public static class HeadingCalculator
    {
        /// <summary>
        /// Headings in clockwise order, starting with North at index 0.
        /// </summary>
        private static readonly List<Heading> HeadingsClockwise = new List<Heading>
        {
            Heading.North,
            Heading.East,
            Heading.South,
            Heading.West
        };

        /// <summary>
        /// Headings in counter clockwise order, starting with North at index 0.
        /// </summary>
        private static readonly List<Heading> HeadingsCounterClockwise = new List<Heading>
        {
            Heading.North,
            Heading.West,
            Heading.South,
            Heading.East
        };

        /// <summary>
        /// Given a heading, return the new heading after a turn.
        /// </summary>
        /// <param name="current">Heading before the turn.</param>
        /// <param name="movement">Direction of the turn.</param>
        /// <returns>Heading after the turn.</returns>
        public static Heading Turn(Heading current, Movement movement)
        {
            // Heading does not change if the movement is straight ahead.
            if (movement == Movement.Move)
            {
                return current;
            }

            // Select the correct order of headings based on the direction of the turn.
            var headings = movement == Movement.Right ? HeadingsClockwise : HeadingsCounterClockwise;

            var index = headings.IndexOf(current);
            index = (index + 1) % headings.Count;

            return headings[index];
        }
    }
}
