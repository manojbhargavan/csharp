using System;
using Xunit;

namespace Extension.Tests
{
    public class DateTimeExtensionTests
    {
        [Theory]
        [InlineData(2019, 1, 1, 20190101)]
        [InlineData(2019, 1, 31, 20190131)]
        [InlineData(2019, 11, 30, 20191130)]
        [InlineData(2019, 11, 01, 20191101)]
        public void TimeId_Extension_ReturnsInt(int year, int month, int day, int expectedResult)
        {
            // Arrange
            DateTime testDateTime = new DateTime(year, month, day);

            // Act
            var actualResult = testDateTime.TimeId();

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1920, 12, 31, "0201231")]
        [InlineData(2013, 10, 31, "1131031")]
        public void LegacyFormat_Extension_ReturnsString(int year, int month, int day, string expectedResult)
        {
            // Arrange
            DateTime testDateTime = new DateTime(year, month, day);

            // Act
            var actualResult = testDateTime.LegacyFormat();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}