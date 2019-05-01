using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class FakeCommandSetDispatcher : ICommandSetDispatcher
    {
        private readonly Action<CommandSet> dispatchCheck;

        public FakeCommandSetDispatcher(Action<CommandSet> dispatchCheck)
        {
            this.dispatchCheck = dispatchCheck;
        }

        public FakeCommandSetDispatcher()
            : this(null)
        {
        }

        public void Dispatch(CommandSet commandSet)
        {
            this.dispatchCheck?.Invoke(commandSet);
        }
    }
}
