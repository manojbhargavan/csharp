using System.Collections.Generic;

namespace Extension.RefData.Implementation
{
    public abstract class XmlDataSource
    {
        public string Name { get; set; } = "XML";
    }

    public class XmlReferenceDataSource : XmlDataSource, IReferenceData
    {
        public IEnumerable<ReferenceData> GetItems()
        {
            return new List<ReferenceData>
            {
                new ReferenceData { Code = "xyz", Description = "from XML" },
                new ReferenceData { Code = "xyz", Description = "from XML 2" }
            };
        }
    }
}