using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    [TestClass]
    public class PositionCalculatorTest
    {
        [TestMethod]
        public void MoveOnNorthHeadingFromPositiveYAxisShouldReturnPositiveYAxis()
        {
            var heading = Heading.North;
            var start = new Point(2, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, 3), result);
        }

        [TestMethod]
        public void MoveOnNorthHeadingFromNegativeYAxisShouldReturnNegativeYAxis()
        {
            var heading = Heading.North;
            var start = new Point(2, -2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, -1), result);
        }

        [TestMethod]
        public void MoveOnNorthHeadingFromNegativeYAxisShouldReturnZeroYAxis()
        {
            var heading = Heading.North;
            var start = new Point(2, -1);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, 0), result);
        }

        [TestMethod]
        public void MoveOnNorthHeadingFromZeroYAxisShouldReturnPositiveYAxis()
        {
            var heading = Heading.North;
            var start = new Point(2, 0);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, 1), result);
        }

        [TestMethod]
        public void MoveOnEastHeadingFromPositiveXAxisShouldReturnPositiveXAxis()
        {
            var heading = Heading.East;
            var start = new Point(2, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(3, 2), result);
        }

        [TestMethod]
        public void MoveOnEastHeadingFromNegativeXAxisShouldReturnNegativeXAxis()
        {
            var heading = Heading.East;
            var start = new Point(-2, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(-1, 2), result);
        }

        [TestMethod]
        public void MoveOnEastHeadingFromNegativeXAxisShouldReturnZeroXAxis()
        {
            var heading = Heading.East;
            var start = new Point(-1, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(0, 2), result);
        }

        [TestMethod]
        public void MoveOnEastHeadingFromZeroXAxisShouldReturnPositiveXAxis()
        {
            var heading = Heading.East;
            var start = new Point(0, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(1, 2), result);
        }

        [TestMethod]
        public void MoveOnSouthHeadingFromPositiveYAxisShouldReturnPositiveYAxis()
        {
            var heading = Heading.South;
            var start = new Point(2, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, 1), result);
        }

        [TestMethod]
        public void MoveOnSouthHeadingFromNegativeYAxisShouldReturnNegativeYAxis()
        {
            var heading = Heading.South;
            var start = new Point(2, -2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, -3), result);
        }

        [TestMethod]
        public void MoveOnSouthHeadingFromPositiveYAxisShouldReturnZeroYAxis()
        {
            var heading = Heading.South;
            var start = new Point(2, 1);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, 0), result);
        }

        [TestMethod]
        public void MoveOnSouthHeadingFromZeroYAxisShouldReturnNegativeYAxis()
        {
            var heading = Heading.South;
            var start = new Point(2, 0);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(2, -1), result);
        }

        [TestMethod]
        public void MoveOnWestHeadingFromPositiveXAxisShouldReturnPositiveXAxis()
        {
            var heading = Heading.West;
            var start = new Point(2, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(1, 2), result);
        }

        [TestMethod]
        public void MoveOnWestHeadingFromNegativeXAxisShouldReturnNegativeXAxis()
        {
            var heading = Heading.West;
            var start = new Point(-2, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(-3, 2), result);
        }

        [TestMethod]
        public void MoveOnWestHeadingFromPositiveXAxisShouldReturnZeroXAxis()
        {
            var heading = Heading.West;
            var start = new Point(1, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(0, 2), result);
        }

        [TestMethod]
        public void MoveOnWestHeadingFromZeroXAxisShouldReturnNegativeXAxis()
        {
            var heading = Heading.West;
            var start = new Point(0, 2);

            var result = PositionCalculator.Move(heading, start);

            Assert.AreEqual(new Point(-1, 2), result);
        }
    }
}
