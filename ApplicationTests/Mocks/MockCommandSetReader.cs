using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
