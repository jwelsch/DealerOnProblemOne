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
