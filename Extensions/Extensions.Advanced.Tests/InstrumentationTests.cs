using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Extensions.Advanced.Tests
{
    public class InstrumentationTests
    {
        [Fact]
        public void GetTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(700);
            Assert.Equal(1, instrumentation.GetElapsedTime());
        }

        [Fact]
        public void GetPreciseTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartPrecise();
            Thread.Sleep(700);
            var result = instrumentation.GetPreciseElapsedTimeAndStop();
            Assert.True(result >= 700 && result <= 702);
        }
    }
}
