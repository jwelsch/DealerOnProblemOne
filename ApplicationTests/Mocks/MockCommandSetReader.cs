using DealerOnProblemOne;
using System;

namespace ApplicationTests.Mocks
{
    public class MockCommandSetReader : ICommandSetReader
    {
        private readonly Func<string> readReturn;

        public MockCommandSetReader(Func<string> readReturn = null)
        {
            this.readReturn = readReturn;
        }

        public string Read()
        {
            return this.readReturn?.Invoke();
        }
    }
}
