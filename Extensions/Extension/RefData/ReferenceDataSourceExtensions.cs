using System.Collections.Generic;
using System.Linq;
namespace Extension.RefData
{
    public static class ReferenceDataSourceExtensions
    {
        public static IEnumerable<ReferenceData> GetItemsByCode(this IReferenceData source, string code)
        {
            var data = source.GetItems();
            var result = data.Where(d => d.Code == code);
            return result;
        }
    }
}