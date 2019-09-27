using Extension.RefData;
using Extension.RefData.Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Extension.Tests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void ToJsonString_Test()
        {
            // Arrange 
            var obj1 = int.MaxValue;
            Debug.WriteLine($"obj1 - {obj1.ToJsonString()}");

            var obj2 = new DateTime(200, 12, 21);
            Debug.WriteLine($"obj1 - {obj2.ToJsonString()}");

            var obj3 = new ReferenceData { Code = "xyz", Description = "123" };
            Debug.WriteLine($"obj3 - {obj3.ToJsonString()}");

            IEnumerable<IReferenceData> obj4 = new List<IReferenceData> {
                new SqlReferenceDataSource(), new ApiReferenceDataSource()
            };
            Debug.WriteLine($"obj4 - {obj4.ToJsonString()}");

            // Act

            // Assert
        }

        [Fact]
        public void GetJsonTypeDescription_Test()
        {
            // Arrange 
            var obj1 = int.MaxValue;
            Debug.WriteLine($"obj1 - {obj1.GetJsonTypeDescription()}");

            var obj2 = new DateTime(200, 12, 21);
            Debug.WriteLine($"obj1 - {obj2.GetJsonTypeDescription()}");

            var obj3 = new ReferenceData { Code = "xyz", Description = "123" };
            Debug.WriteLine($"obj3 - {obj3.GetJsonTypeDescription()}");

            IEnumerable<IReferenceData> obj4 = new List<IReferenceData> {
                new SqlReferenceDataSource(), new ApiReferenceDataSource()
            };
            Debug.WriteLine($"obj4 - {obj4.GetJsonTypeDescription()}");

            // Act

            // Assert
        }
    }
}
