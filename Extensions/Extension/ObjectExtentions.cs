using Extension.RefData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class ObjectExtentions
    {
        public static string ToJsonString(this object sourceObject)
        {
            return JsonConvert.SerializeObject(sourceObject);
        }

        public static string GetJsonTypeDescription(this object sourceObject)
        {
            return sourceObject.GetType().GetDescription().ToJsonString();
        }

        public static TypeDescription GetDescription(this Type sourceType)
        {
            return new TypeDescription
            {
                FullName = sourceType.FullName,
                AssemblyQualifiedName = sourceType.AssemblyQualifiedName
            };
        }
    }
}
