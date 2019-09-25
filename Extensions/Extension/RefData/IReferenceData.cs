using System.Collections;
namespace Extension.RefData
{
    public interface IReferenceData
    {
        IEnumerable<ReferenceData> GetItems();
    }
}