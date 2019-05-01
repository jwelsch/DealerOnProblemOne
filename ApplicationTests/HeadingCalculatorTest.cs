using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationTests
{
    [TestClass]
    public class HeadingCalculatorTest
    {
        [TestMethod]
        public void NoTurnsShouldNotChangeHeading()
        {
            var oldHeading = Heading.North;

            var newHeading = HeadingCalculator.Turn(oldHeading, Movement.Move);

            Assert.AreEqual(oldHeading, newHeading);
        }

        [TestMethod]
        public void TurnToRightFromNorthShouldReturnEast()
        {
            var oldHeading = Heading.North;

            var newHeading = HeadingCalculator.Turn(oldHeading, Movement.Right);

            Assert.AreEqual(Heading.East, newHeading);
        }

        [TestMethod]
        public void TurnToLeftFromNorthShouldReturnWest()
        {
            var oldHeading = Heading.North;

            var newHeading = HeadingCalculator.Turn(oldHeading, Movement.Left);

            Assert.AreEqual(Heading.West, newHeading);
        }

        [TestMethod]
        public void TurnToLeftFromWestShouldReturnSouth()
        {
            var oldHeading = Heading.West;

            var newHeading = HeadingCalculator.Turn(oldHeading, Movement.Left);

            Assert.AreEqual(Heading.South, newHeading);
        }

        [TestMethod]
        public void TurnToRightFromWestShouldReturnNorth()
        {
            var oldHeading = Heading.West;

            var newHeading = HeadingCalculator.Turn(oldHeading, Movement.Right);

            Assert.AreEqual(Heading.North, newHeading);
        }
    }
}
