using System;

namespace ExtensionInternal
{
    public static class DateTimeExtension
    {
        public static string ToXmlDateTimeString(this DateTime dateTime)
        {
            return $"{dateTime:o}";
        }
    }
}
