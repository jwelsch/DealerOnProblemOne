using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ApplicationTests
{
    [TestClass]
    public class ConfirmPositionCommandTest
    {
        [TestMethod]
        public void CorrectInstructionsShouldCreateObjectSuccessfully()
        {
            var instructions = "4 5 N";

            var command = new ConfirmPositionCommand(instructions);

            Assert.IsNotNull(command);
            Assert.AreEqual(instructions, command.Instructions);
            Assert.AreEqual(4, command.Coordinates.X);
            Assert.AreEqual(5, command.Coordinates.Y);
            Assert.AreEqual(Heading.North, command.Heading);
        }

        [TestMethod]
        public void InstructionsWithTwoValuesShouldThrowException()
        {
            var instructions = "4 5";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithFourValuesShouldThrowException()
        {
            var instructions = "4 5 N E";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithIncorrectlyFormattedPositionValueShouldThrowException()
        {
            var instructions = "4 N E";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithIncorrectlyFormattedHeadingValueShouldThrowException()
        {
            var instructions = "4 5 6";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNegativeXValueShouldThrowException()
        {
            var instructions = "-4 5 N";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNegativeYValueShouldThrowException()
        {
            var instructions = "4 -5 N";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNoValuesShouldThrowException()
        {
            var instructions = "";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNullValueShouldThrowException()
        {
            string instructions = null;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new ConfirmPositionCommand(instructions);
            });
        }
    }
}
