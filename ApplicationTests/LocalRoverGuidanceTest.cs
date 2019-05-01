using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    [TestClass]
    public class LocalRoverGuidanceTest
    {
        [TestMethod]
        public void MoveWithValidCommandSetShouldHaveCorrectPositionAndHeading()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LMRM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            guidance.Move(commandSet);

            Assert.AreEqual(0, guidance.Coordinates.X);
            Assert.AreEqual(3, guidance.Coordinates.Y);
            Assert.AreEqual(Heading.North, guidance.Heading);
        }

        [TestMethod]
        public void MoveWithNoMovesShouldHaveCorrectPositionAndHeading()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            guidance.Move(commandSet);

            Assert.AreEqual(1, guidance.Coordinates.X);
            Assert.AreEqual(2, guidance.Coordinates.Y);
            Assert.AreEqual(Heading.North, guidance.Heading);
        }

        [TestMethod]
        public void MoveWithInvalidEstablishGridCommandShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("-5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LMRM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                guidance.Move(commandSet);
            });
        }

        [TestMethod]
        public void MoveWithInvalidConfirmPositionCommandShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("-1 2 N");
            var move = new MoveCommand("LMRM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                guidance.Move(commandSet);
            });
        }

        [TestMethod]
        public void MoveWithMoveCommandGoingPastXOriginShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LMM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                guidance.Move(commandSet);
            });
        }

        [TestMethod]
        public void MoveWithMoveCommandGoingPastXMaximumShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("RMMMMM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                guidance.Move(commandSet);
            });
        }

        [TestMethod]
        public void MoveWithMoveCommandGoingPastYOriginShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LLMMM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                guidance.Move(commandSet);
            });
        }

        [TestMethod]
        public void MoveWithMoveCommandGoingPastYMaximumShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("MMMMM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new LocalRoverGuidance();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                guidance.Move(commandSet);
            });
        }
    }
}
