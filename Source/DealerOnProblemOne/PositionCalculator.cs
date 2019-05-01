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
        public static Point Move(Heading heading, Point position)
        {
            switch (heading)
            {
                case Heading.North:
                    return new Point(position.X, position.Y + 1);
                case Heading.South:
                    return new Point(position.X, position.Y - 1);
                case Heading.East:
                    return new Point(position.X + 1, position.Y);
                case Heading.West:
                    return new Point(position.X - 1, position.Y);
                default:
                    throw new ArgumentException($"Unknown heading {heading} specified.", nameof(heading));
            }
        }
    }
}
