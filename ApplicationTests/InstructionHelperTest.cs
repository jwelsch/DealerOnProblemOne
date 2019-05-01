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
    }
}
