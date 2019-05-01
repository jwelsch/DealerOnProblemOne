﻿using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
