using ApplicationTests.Mocks;
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
    public class LocalCommandSetDispatcherTest
    {
        [TestMethod]
        public void DispatchWithValidCommandSetShouldTransmitCorrectData()
        {
            var establishGrid = new EstablishGridCommand("5 5");
            var confirmPosition = new ConfirmPositionCommand("1 2 N");
            var move = new MoveCommand("LMRM");

            var commandSet = new CommandSet(establishGrid, confirmPosition, move);

            var guidance = new MockRoverGuidance(cs =>
            {
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
            }, p => new Point(2, 1), h => Heading.North);

            var listener = new MockCommandSetListener(m =>
            {
                Assert.AreEqual("2 1 N", m);
            });

            var dispatcher = new LocalCommandSetDispatcher(guidance, listener);

            dispatcher.Dispatch(commandSet);
        }

        [TestMethod]
        public void DispatchWithNullCommandSetShouldThrowException()
        {
            var dispatcher = new LocalCommandSetDispatcher(new MockRoverGuidance(), new MockCommandSetListener());

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                dispatcher.Dispatch(null);
            });
        }

        [TestMethod]
        public void ConstructorWithNullGuidanceShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var dispatcher = new LocalCommandSetDispatcher(null, new MockCommandSetListener());
            });
        }

        [TestMethod]
        public void ConstructorWithNullListenerShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var dispatcher = new LocalCommandSetDispatcher(new MockRoverGuidance(), null);
            });
        }
    }
}
