using System;
using Xunit;

namespace ExtensionInternal.Tests
{
    public class DateTimeExtensionTests
    {
        [Fact]
        public void StaticCallVsExtensionCall()
        {
            string result1 = DateTimeExtension.ToXmlDateTimeString(new DateTime(2019, 12, 21));
            string result2 = (new DateTime(2019, 12, 21)).ToXmlDateTimeString();
            Assert.Equal(result1, result2);
        }
    }
}
