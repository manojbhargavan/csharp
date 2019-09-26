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
            IReferenceData data = (IReferenceData)Activator.CreateInstance(ImplementationType);

            // Act
            var actualCount = data.GetItems().ToList().Count;

            // Assert
            Assembly.Equals(expectedCount, actualCount);
        }

        [Theory]
        [InlineData(typeof(ApiReferenceDataSource),"xyz", 2)]
        [InlineData(typeof(SqlReferenceDataSource),"xyz", 2)]
        [InlineData(typeof(XmlReferenceDataSource),"xyz", 2)]
        public void GetItemsByCode_Get2PerSource(Type ImplementationType, string code, int expectedCount)
        {
            // Arrange
            IReferenceData data = (IReferenceData)Activator.CreateInstance(ImplementationType);

            // Act
            var actualCount = data.GetItemsByCode(code).ToList().Count;

            // Assert
            Assembly.Equals(expectedCount, actualCount);
        }
    }
}