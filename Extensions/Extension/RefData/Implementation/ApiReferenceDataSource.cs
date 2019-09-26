using System.Collections.Generic;

namespace Extension.RefData.Implementation
{
    public abstract class ApiDataSource
    {
        public string Name { get; set; } = "API";
    }

    public class ApiReferenceDataSource : ApiDataSource, IReferenceData
    {
        public IEnumerable<ReferenceData> GetItems()
        {
            return new List<ReferenceData>
            {
                new ReferenceData { Code = "xyz", Description = "from API" },
                new ReferenceData { Code = "xyz", Description = "from API 2" }
            };
        }
    }
}