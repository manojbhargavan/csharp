using System;
using Xunit;

namespace Extension.Tests
{
    public class DateTimeSystemExtensionTests
    {
        [Theory]
        [InlineData(2019, 11, 21, "2019-11-21T00:00:00.0000000")]
        public void ToXmlDateTime_Extension_ConvertsToUTCFormat(int year, int month, int day, string expectedResult)
        {
            // Arrange
            var dateTime = new DateTime(year, month, day);

            // Act
            var actualResult = dateTime.ToXmlDateTime();

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}