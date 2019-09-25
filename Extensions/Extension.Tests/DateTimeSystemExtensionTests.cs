using System;
using Xunit;

namespace Extension.Tests
{
    public class DateTimeSystemExtensionTests
    {
        [Theory]
        [InlineData(2019, 11, 21, 0, 0, 0,0, "2019-11-21T00:00:00.0000000")]
        [InlineData(2019, 11, 21, 9, 7, 5,5, "2019-11-21T09:07:05.0050000")]
        [InlineData(2019, 11, 21, 13, 23, 34, 22, "2019-11-21T13:23:34.0220000")]
        [InlineData(2019, 11, 21, 13, 23, 34, 922, "2019-11-21T13:23:34.9220000")]
        public void ToXmlDateTime_Extension_ConvertsToUTCFormat(int year, int month, int day,
        int hours, int minutes, int seconds, int millisecond, string expectedResult)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day, hours, minutes, seconds, millisecond);

            // Act
            var actualResult = dateTime.ToXmlDateTime();

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}