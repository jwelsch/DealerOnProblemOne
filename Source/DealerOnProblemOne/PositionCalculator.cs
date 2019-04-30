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
            var result = position;

            switch (heading)
            {
                case Heading.North:
                    result.Y += 1;
                    break;
                case Heading.South:
                    result.Y -= 1;
                    break;
                case Heading.East:
                    result.X += 1;
                    break;
                case Heading.West:
                    result.Y -= 1;
                    break;
                default:
                    throw new ArgumentException($"Unknown heading {heading} specified.", nameof(heading));
            }

            return result;
        }
    }
}
