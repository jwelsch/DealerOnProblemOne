﻿using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ApplicationTests
{
    [TestClass]
    public class EstablishGridCommandTest
    {
        [TestMethod]
        public void CorrectInstructionsShouldCreateObjectSuccessfully()
        {
            var instructions = "4 5";

            var command = new EstablishGridCommand(instructions);

            Assert.IsNotNull(command);
            Assert.AreEqual(instructions, command.Instructions);
            Assert.AreEqual(4, command.Grid.Width);
            Assert.AreEqual(5, command.Grid.Height);
        }

        [TestMethod]
        public void ZeroByZeroGridSizeShouldCreateObjectSuccessfully()
        {
            var instructions = "0 0";

            var command = new EstablishGridCommand(instructions);

            Assert.IsNotNull(command);
            Assert.AreEqual(instructions, command.Instructions);
            Assert.AreEqual(0, command.Grid.Width);
            Assert.AreEqual(0, command.Grid.Height);
        }

        [TestMethod]
        public void InstructionsWithOneValueShouldThrowException()
        {
            var instructions = "4";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithThreeValuesShouldThrowException()
        {
            var instructions = "4 5 N";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithIncorrectlyFormattedValuesShouldThrowException()
        {
            var instructions = "4 N";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNegativeXValueShouldThrowException()
        {
            var instructions = "-4 5";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNegativeYValueShouldThrowException()
        {
            var instructions = "4 -5";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNoValuesShouldThrowException()
        {
            var instructions = "";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNullValueShouldThrowException()
        {
            string instructions = null;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new EstablishGridCommand(instructions);
            });
        }
    }
}
