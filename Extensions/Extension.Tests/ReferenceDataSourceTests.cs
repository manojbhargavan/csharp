using Extension.RefData.Implementation;
using Extension.RefData;
using System.Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Extension.Tests
{
    public class ReferenceDataSourceTests
    {
        [Theory]
        [InlineData(typeof(ApiReferenceDataSource), 2)]
        [InlineData(typeof(SqlReferenceDataSource), 2)]
        [InlineData(typeof(XmlReferenceDataSource), 2)]
        public void GetItems_Get2PerSource(Type ImplementationType, int expectedCount)
        {
            // Arrange
            var data = (IReferenceData)Activator.CreateInstance(ImplementationType);

            // Act
            var actualCount = data.GetItems().ToList().Count;

            // Assert
            Assembly.Equals(expectedCount, actualCount);
        }

        [Fact]
        public void GetItemsByCode_Get2PerSource()
        {
            // Arrange
            IReferenceData[] data = new IReferenceData[] 
            {
                new ApiReferenceDataSource(),            
                new SqlReferenceDataSource(),            
                new XmlReferenceDataSource() 
            };
            
            // Act
            var actualCount = data.GetAllItemsByCode("xyz").ToList().Count;

            // Assert
            Assert.Equal(6, actualCount);
        }
    }
}