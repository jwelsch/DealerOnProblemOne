using DealerOnProblemOne;
using System;

namespace ApplicationTests.Mocks
{
    public class MockCommandSetDispatcherFactory : ICommandSetDispatcherFactory
    {
        private readonly Action<CommandSet> dispatchCheck;

        public MockCommandSetDispatcherFactory(Action<CommandSet> dispatchCheck = null)
        {
            this.dispatchCheck = dispatchCheck;
        }

        public ICommandSetDispatcher Create()
        {
            return new MockCommandSetDispatcher(this.dispatchCheck);
        }
    }
}
