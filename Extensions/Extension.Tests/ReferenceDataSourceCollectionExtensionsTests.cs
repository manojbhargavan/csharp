using Xunit;
using System.Collections.Generic;
using Extension.RefData.Implementation;
using System;
using Extension.RefData;
using System.Reflection;
using System.Linq;
using System.Collections;

namespace Extension.Tests
{
    public class ReferenceDataSourceCollectionExtensionsTests
    {
        [Fact]
        public void GetAllItemsByCode_Get2PerSource()
        {
            // Arrange
            var source = new IReferenceData[] { new ApiReferenceDataSource(), new SqlReferenceDataSource(), new XmlReferenceDataSource() };

            // Act
            var actualCount = source.GetAllItemsByCode("xyz").Count();

            // Assert
            Assert.Equal(6, actualCount);
        }

        [Fact]
        public void GetAllItemsByCode_ALGet2PerSource()
        {
            // Arrange
            var source = new ArrayList() { new ApiReferenceDataSource(), new SqlReferenceDataSource(), new XmlReferenceDataSource() };
            source.Add("Some random text");
            
            // Act
            var actualCount = source.GetAllItemsByCode("xyz").Count();

            // Assert
            Assert.Equal(6, actualCount);
        }

        [Fact]
        public void GetAllItemsByCode_IEnumerable()
        {
            // Arrange
            var source = new HashSet<IReferenceData> { new ApiReferenceDataSource(), new SqlReferenceDataSource(), new XmlReferenceDataSource() };
            
            // Act
            var actualCount = source.GetAllItemsByCode("xyz").Count();

            // Assert
            Assert.Equal(6, actualCount);
        }
    }
}