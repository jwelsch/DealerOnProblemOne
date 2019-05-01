using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerOnProblemOne
{
    public static class PositionCalculator
    {
        public static Point Move(Heading heading, Point startPosition)
        {
            switch (heading)
            {
                case Heading.North:
                    return new Point(startPosition.X, startPosition.Y + 1);
                case Heading.South:
                    return new Point(startPosition.X, startPosition.Y - 1);
                case Heading.East:
                    return new Point(startPosition.X + 1, startPosition.Y);
                case Heading.West:
                    return new Point(startPosition.X - 1, startPosition.Y);
                default:
                    throw new ArgumentException($"Unknown heading {heading} specified.", nameof(heading));
            }
        }
    }
}
