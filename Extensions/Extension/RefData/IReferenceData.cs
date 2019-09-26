using System.Collections.Generic;
namespace Extension.RefData
{
    public interface IReferenceData
    {
        IEnumerable<ReferenceData> GetItems();
    }
}