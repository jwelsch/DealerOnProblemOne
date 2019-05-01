using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ApplicationTests
{
    [TestClass]
    public class MoveCommandTest
    {
        [TestMethod]
        public void CorrectInstructionsShouldCreateObjectSuccessfully()
        {
            var instructions = "MLMLMRMRM";

            var command = new MoveCommand(instructions);

            Assert.IsNotNull(command);
            Assert.AreEqual(instructions, command.Instructions);
            Assert.AreEqual(instructions.Length, command.Moves.Count);
            Assert.AreEqual(Movement.Move, command.Moves[0]);
            Assert.AreEqual(Movement.Left, command.Moves[1]);
            Assert.AreEqual(Movement.Move, command.Moves[2]);
            Assert.AreEqual(Movement.Left, command.Moves[3]);
            Assert.AreEqual(Movement.Move, command.Moves[4]);
            Assert.AreEqual(Movement.Right, command.Moves[5]);
            Assert.AreEqual(Movement.Move, command.Moves[6]);
            Assert.AreEqual(Movement.Right, command.Moves[7]);
            Assert.AreEqual(Movement.Move, command.Moves[8]);
        }

        [TestMethod]
        public void InstructionsWithIncorrectlyFormattedValueShouldThrowException()
        {
            var instructions = "MLMLNRMRM";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var command = new MoveCommand(instructions);
            });
        }

        [TestMethod]
        public void InstructionsWithNoValuesShouldCreateObjectSuccessfully()
        {
            var instructions = "";

            var command = new MoveCommand(instructions);

            Assert.IsNotNull(command);
            Assert.AreEqual(instructions, command.Instructions);
            Assert.AreEqual(instructions.Length, command.Moves.Count);
        }

        [TestMethod]
        public void InstructionsWithNullValueShouldThrowException()
        {
            string instructions = null;

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var command = new MoveCommand(instructions);
            });
        }
    }
}
