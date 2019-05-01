using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests.Mocks
{
    public class MockCommandSetDispatcherFactory : ICommandSetDispatcherFactory
    {
        private readonly Action<CommandSet> dispatchCheck;

        public MockCommandSetDispatcherFactory(Action<CommandSet> dispatchCheck)
        {
            this.dispatchCheck = dispatchCheck;
        }

        public MockCommandSetDispatcherFactory()
            : this(null)
        {
        }

        public ICommandSetDispatcher Create()
        {
            return new MockCommandSetDispatcher(this.dispatchCheck);
        }
    }
}
