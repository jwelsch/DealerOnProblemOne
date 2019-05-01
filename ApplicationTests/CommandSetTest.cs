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
    public class CommandSetTest
    {
        [TestMethod]
        public void CorrectArgumentsShouldCreateObjectSuccessfully()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LMRM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            Assert.IsNotNull(commandSet);
            Assert.AreEqual(establishGrid.Instructions, commandSet.EstablishGrid.Instructions);
            Assert.AreEqual(establishGrid.Grid.Width, commandSet.EstablishGrid.Grid.Width);
            Assert.AreEqual(establishGrid.Grid.Height, commandSet.EstablishGrid.Grid.Height);
            Assert.AreEqual(confirmPosition.Instructions, commandSet.ConfirmPosition.Instructions);
            Assert.AreEqual(confirmPosition.Coordinates.X, commandSet.ConfirmPosition.Coordinates.X);
            Assert.AreEqual(confirmPosition.Coordinates.Y, commandSet.ConfirmPosition.Coordinates.Y);
            Assert.AreEqual(confirmPosition.Heading, commandSet.ConfirmPosition.Heading);
            Assert.AreEqual(move.Instructions, commandSet.Move.Instructions);
            Assert.AreEqual(move.Moves.Count, commandSet.Move.Moves.Count);
            Assert.AreEqual(move.Moves[0], commandSet.Move.Moves[0]);
            Assert.AreEqual(move.Moves[1], commandSet.Move.Moves[1]);
            Assert.AreEqual(move.Moves[2], commandSet.Move.Moves[2]);
            Assert.AreEqual(move.Moves[3], commandSet.Move.Moves[3]);
        }

        [TestMethod]
        public void NullEstablishGridShouldThrowException()
        {
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LMRM");

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var commandSet = new CommandSet(null, confirmPosition, move);
            });
        }

        [TestMethod]
        public void NullConfirmPositionShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var move = new MoveCommand("LMRM");

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var commandSet = new CommandSet(establishGrid, null, move);
            });
        }

        [TestMethod]
        public void NullMoveShouldThrowException()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var commandSet = new CommandSet(establishGrid, confirmPosition, null);
            });
        }
    }
}
