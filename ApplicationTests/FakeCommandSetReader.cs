using DealerOnProblemOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class FakeCommandSetReader : ICommandSetReader
    {
        private readonly Func<string> readReturn;

        public FakeCommandSetReader(Func<string> readReturn)
        {
            this.readReturn = readReturn;
        }

        public FakeCommandSetReader()
            : this(null)
        {
        }

        public string Read()
        {
            return this.readReturn?.Invoke();
        }
    }
}
