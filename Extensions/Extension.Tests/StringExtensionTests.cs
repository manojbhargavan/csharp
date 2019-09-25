using Xunit;
namespace Extension.Tests
{
    public class StringExtensionTests
    {
        [Theory]
        [InlineData("Manoj","Bhargavan","BHARGAVAN, MANOJ")]
        [InlineData("Nandan Manoj","Bhargavan","BHARGAVAN, NANDAN MANOJ")]
        public void GetFormattedName_ReturnsFormattedName(string firstName,string lastName, string expectedResult)
        {
            // Arrange
                        
            // Act
            var actualResult = firstName.GetFormattedName(lastName);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("Manoj, Bhargavan","BHARGAVAN, MANOJ")]
        [InlineData("Nandan Manoj, Bhargavan","BHARGAVAN, NANDAN MANOJ")]
        public void GetFormattedNameString_ReturnsFormattedName(string fullName, string expectedResult)
        {
            // Arrange
                        
            // Act
            var actualResult = fullName.GetFormattedName();

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}