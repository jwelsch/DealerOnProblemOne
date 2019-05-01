using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ApplicationTests
{
    [TestClass]
    public class InstructionHelperTest
    {
        [TestMethod]
        public void SplitLineWithThreeValuesReturnsThreeResults()
        {
            var line = "1 2 N";
            var count = 3;

            var result = InstructionHelper.SplitLine(line, count);

            Assert.AreEqual(count, result.Length);
            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);
            Assert.AreEqual("N", result[2]);
        }

        [TestMethod]
        public void SplitLineWithOneValueReturnsOneResult()
        {
            var line = "foo";
            var count = 1;

            var result = InstructionHelper.SplitLine(line, count);

            Assert.AreEqual(count, result.Length);
            Assert.AreEqual("foo", result[0]);
        }

        [TestMethod]
        public void SplitLineWithEmptyValueReturnsEmptyResult()
        {
            var line = string.Empty;
            var count = 0;

            var result = InstructionHelper.SplitLine(line, count);

            Assert.AreEqual(count, result.Length);
        }

        [TestMethod]
        public void SplitLineWithNullValueThrowsException()
        {
            Assert.ThrowsException<NullReferenceException>(() =>
            {
                var result = InstructionHelper.SplitLine(null, 0);
            });
        }

        [TestMethod]
        public void SplitLineWithTwoValueThrowsExceptionWhenExpectingThree()
        {
            var line = "1 2";
            var count = 3;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.SplitLine(line, count);
            });
        }

        [TestMethod]
        public void ConvertToIntWithValidPositiveValueShouldReturnInteger()
        {
            var value = "123";

            var result = InstructionHelper.ConvertToInt(value);

            Assert.AreEqual(int.Parse(value), result);
        }

        [TestMethod]
        public void ConvertToIntWithValidNegativeValueShouldReturnInteger()
        {
            var value = "-123";

            var result = InstructionHelper.ConvertToInt(value);

            Assert.AreEqual(int.Parse(value), result);
        }

        [TestMethod]
        public void ConvertToIntWithZeroValueShouldReturnInteger()
        {
            var value = "0";

            var result = InstructionHelper.ConvertToInt(value);

            Assert.AreEqual(int.Parse(value), result);
        }

        [TestMethod]
        public void ConvertToIntWithInvalidValueShouldThrowException()
        {
            var value = "foo";

            Assert.ThrowsException<FormatException>(() =>
            {
                var result = InstructionHelper.ConvertToInt(value);
            });
        }

        [TestMethod]
        public void ConvertToIntWithEmptyValueShouldThrowException()
        {
            var value = string.Empty;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertToInt(value);
            });
        }

        [TestMethod]
        public void ConvertToIntWithNullValueShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var result = InstructionHelper.ConvertToInt(null);
            });
        }

        [TestMethod]
        public void ConvertStringToHeadingWithNValueShouldReturnInteger()
        {
            var value = "N";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.North, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithSValueShouldReturnInteger()
        {
            var value = "S";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.South, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithEValueShouldReturnInteger()
        {
            var value = "E";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.East, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithWValueShouldReturnInteger()
        {
            var value = "W";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.West, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithLowerNValueShouldReturnInteger()
        {
            var value = "n";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.North, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithLowerSValueShouldReturnInteger()
        {
            var value = "s";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.South, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithLowerEValueShouldReturnInteger()
        {
            var value = "e";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.East, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithLowerWValueShouldReturnInteger()
        {
            var value = "w";

            var result = InstructionHelper.ConvertStringToHeading(value);

            Assert.AreEqual(Heading.West, result);
        }

        [TestMethod]
        public void ConvertStringToHeadingWithInvalidSingleCharacterValueShouldThrowException()
        {
            var value = "f";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertStringToHeading(value);
            });
        }

        [TestMethod]
        public void ConvertStringToHeadingWithInvalidValueShouldThrowException()
        {
            var value = "foo";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertStringToHeading(value);
            });
        }

        [TestMethod]
        public void ConvertStringToHeadingWithEmptyValueShouldThrowException()
        {
            var value = string.Empty;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertStringToHeading(value);
            });
        }

        [TestMethod]
        public void ConvertStringToHeadingWithNullValueShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var result = InstructionHelper.ConvertStringToHeading(null);
            });
        }

        [TestMethod]
        public void ConvertHeadingToStringWithNValueShouldReturnInteger()
        {
            var value = Heading.North;

            var result = InstructionHelper.ConvertHeadingToString(value);

            Assert.AreEqual("N", result);
        }

        [TestMethod]
        public void ConvertHeadingToStringWithSValueShouldReturnInteger()
        {
            var value = Heading.South;

            var result = InstructionHelper.ConvertHeadingToString(value);

            Assert.AreEqual("S", result);
        }

        [TestMethod]
        public void ConvertHeadingToStringWithEValueShouldReturnInteger()
        {
            var value = Heading.East;

            var result = InstructionHelper.ConvertHeadingToString(value);

            Assert.AreEqual("E", result);
        }

        [TestMethod]
        public void ConvertHeadingToStringWithWValueShouldReturnInteger()
        {
            var value = Heading.West;

            var result = InstructionHelper.ConvertHeadingToString(value);

            Assert.AreEqual("W", result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithLValueShouldReturnMovement()
        {
            var value = "L";

            var result = InstructionHelper.ConvertStringToMovement(value);

            Assert.AreEqual(Movement.Left, result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithRValueShouldReturnMovement()
        {
            var value = "R";

            var result = InstructionHelper.ConvertStringToMovement(value);

            Assert.AreEqual(Movement.Right, result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithMValueShouldReturnMovement()
        {
            var value = "M";

            var result = InstructionHelper.ConvertStringToMovement(value);

            Assert.AreEqual(Movement.Move, result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithLowerLValueShouldReturnMovement()
        {
            var value = "l";

            var result = InstructionHelper.ConvertStringToMovement(value);

            Assert.AreEqual(Movement.Left, result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithLowerRValueShouldReturnMovement()
        {
            var value = "r";

            var result = InstructionHelper.ConvertStringToMovement(value);

            Assert.AreEqual(Movement.Right, result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithLowerMValueShouldReturnMovement()
        {
            var value = "m";

            var result = InstructionHelper.ConvertStringToMovement(value);

            Assert.AreEqual(Movement.Move, result);
        }

        [TestMethod]
        public void ConvertStringToMovementWithInvalidValueShouldThrowException()
        {
            var value = "foo";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertStringToMovement(value);
            });
        }

        [TestMethod]
        public void ConvertStringToMovementWithInvalidSingleCharacterValueShouldThrowException()
        {
            var value = "Z";

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertStringToMovement(value);
            });
        }

        [TestMethod]
        public void ConvertStringToMovementWithEmptyValueShouldThrowException()
        {
            var value = string.Empty;

            Assert.ThrowsException<ArgumentException>(() =>
            {
                var result = InstructionHelper.ConvertStringToMovement(value);
            });
        }

        [TestMethod]
        public void ConvertStringToMovementWithNullValueShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var result = InstructionHelper.ConvertStringToMovement(null);
            });
        }
    }
}
