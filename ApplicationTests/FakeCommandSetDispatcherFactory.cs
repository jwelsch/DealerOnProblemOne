using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class FakeCommandSetDispatcherFactory : ICommandSetDispatcherFactory
    {
        private readonly Action<CommandSet> dispatchCheck;

        public FakeCommandSetDispatcherFactory(Action<CommandSet> dispatchCheck)
        {
            this.dispatchCheck = dispatchCheck;
        }

        public FakeCommandSetDispatcherFactory()
            : this(null)
        {
        }

        public ICommandSetDispatcher Create()
        {
            return new FakeCommandSetDispatcher(this.dispatchCheck);
        }
    }
}
