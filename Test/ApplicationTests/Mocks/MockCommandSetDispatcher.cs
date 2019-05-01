using DealerOnProblemOne;
using System;

namespace ApplicationTests.Mocks
{
    public class MockCommandSetDispatcher : ICommandSetDispatcher
    {
        private readonly Action<CommandSet> dispatchCheck;

        public MockCommandSetDispatcher(Action<CommandSet> dispatchCheck = null)
        {
            this.dispatchCheck = dispatchCheck;
        }

        public void Dispatch(CommandSet commandSet)
        {
            this.dispatchCheck?.Invoke(commandSet);
        }
    }
}
