using ApplicationTests.Mocks;
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
    public class CommandSetInterpreterTest
    {
        [TestMethod]
        public void DispatcherShouldGetCorrectCommandSetFromValidInstructions()
        {
            var establishGridInstructions = "10 10";
            var confirmPositionInstructions = "3 4 E";
            var moveInstructions = "LLMMRMM";
            var reader = new MockCommandSetReader(() => $"{establishGridInstructions}{Environment.NewLine}{confirmPositionInstructions}{Environment.NewLine}{moveInstructions}");
            var dispatcherFactory = new MockCommandSetDispatcherFactory(cs =>
            {
                Assert.IsNotNull(cs);
                Assert.AreEqual(establishGridInstructions, cs.EstablishGrid.Instructions);
                Assert.AreEqual(10, cs.EstablishGrid.Grid.Width);
                Assert.AreEqual(10, cs.EstablishGrid.Grid.Height);
                Assert.AreEqual(confirmPositionInstructions, cs.ConfirmPosition.Instructions);
                Assert.AreEqual(3, cs.ConfirmPosition.Coordinates.X);
                Assert.AreEqual(4, cs.ConfirmPosition.Coordinates.Y);
                Assert.AreEqual(Heading.East, cs.ConfirmPosition.Heading);
                Assert.AreEqual(moveInstructions, cs.Move.Instructions);
                Assert.AreEqual(moveInstructions.Length, cs.Move.Moves.Count);
                Assert.AreEqual(Movement.Left, cs.Move.Moves[0]);
                Assert.AreEqual(Movement.Left, cs.Move.Moves[1]);
                Assert.AreEqual(Movement.Move, cs.Move.Moves[2]);
                Assert.AreEqual(Movement.Move, cs.Move.Moves[3]);
                Assert.AreEqual(Movement.Right, cs.Move.Moves[4]);
                Assert.AreEqual(Movement.Move, cs.Move.Moves[5]);
                Assert.AreEqual(Movement.Move, cs.Move.Moves[6]);
            });

            var interpreter = new CommandSetInterpreter(reader, dispatcherFactory);

            interpreter.Interpret();
        }

        [TestMethod]
        public void NullCommandSetReaderShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var interpreter = new CommandSetInterpreter(null, new MockCommandSetDispatcherFactory());
            });
        }

        [TestMethod]
        public void NullCommandSetDispatcherFactoryShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var interpreter = new CommandSetInterpreter(new MockCommandSetReader(), null);
            });
        }
    }
}
