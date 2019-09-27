using System;
using Xunit;

namespace ExtensionInternal.Tests
{
    public class DateTimeExtensionTests
    {
        [Fact]
        public void StaticCallVsExtensionCall()
        {
            var dateTime = new DateTime(2019, 12, 21);
            string result1 = DateTimeExtension.ToXmlDateTimeString(dateTime);
            string result2 = dateTime.ToXmlDateTimeString();
            Assert.Equal(result1, result2);
        }
    }
}
