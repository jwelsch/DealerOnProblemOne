using DealerOnProblemOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ApplicationTests
{
    [TestClass]
    public class FileCommandSetReaderTest
    {
        [TestMethod]
        public void ExistingFileShouldReturnString()
        {
            var path = Path.Combine(Properties.Settings.Default.TestDataPath, "instructions.txt");
            var reader = new FileCommandSetReader(path);

            var readerInstructions = reader.Read();

            using (var stream = new StreamReader(path))
            {
                var streamInstructions = stream.ReadToEnd();

                Assert.AreEqual(streamInstructions, readerInstructions);
            }
        }

        [TestMethod]
        public void NonExistingFileShouldThrowException()
        {
            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                var reader = new FileCommandSetReader("ThisFileDoesNotExist.txt");
            });
        }

        [TestMethod]
        public void EmptyPathShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var reader = new FileCommandSetReader(string.Empty);
            });
        }

        [TestMethod]
        public void NullPathShouldThrowException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var reader = new FileCommandSetReader(null);
            });
        }
    }
}
