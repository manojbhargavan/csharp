using System.Collections.Generic;

namespace Extension.RefData.Implementation
{
    public abstract class SqlDataSource
    {
        public string Name { get; set; } = "SQL";
    }

    public class SqlReferenceDataSource : SqlDataSource, IReferenceData
    {
        public IEnumerable<ReferenceData> GetItems()
        {
            return new List<ReferenceData>
            {
                new ReferenceData { Code = "xyz", Description = "from SQL" },
                new ReferenceData { Code = "xyz", Description = "from SQL 2" }
            };
        }
    }
}