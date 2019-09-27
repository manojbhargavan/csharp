using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Extension.RefData
{
    public static class ReferenceDataSourceCollectionExtensions
    {
        public static IEnumerable<ReferenceData> GetAllItemsByCode(this IEnumerable data, string code)
        {
            List<ReferenceData> fullData = new List<ReferenceData>();
            //data.ToList().ForEach(i => fullData.AddRange(i.GetItems().Where(x => x.Code == code)));
            foreach (var item in data)
            {
                var dataToAdd = (item as IReferenceData)?.GetItems().Where(i => i.Code == code);
                if (dataToAdd != null)
                    fullData.AddRange(dataToAdd);
            }
            return fullData;
        }

        public static IEnumerable<ReferenceData> GetAllItemsByCode(this IEnumerable<IReferenceData> referenceData, string code)
        {
            return referenceData.SelectMany(r => r.GetItemsByCode(code));
        }
    }
}