using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests.Mocks
{
    public class MockCommandSetListener : ICommandSetListener
    {
        private readonly Action<string> transmitCheck;

        public MockCommandSetListener(Action<string> transmitCheck = null)
        {
            this.transmitCheck = transmitCheck;
        }

        public void Transmit(string message)
        {
            this.transmitCheck?.Invoke(message);
        }
    }
}
