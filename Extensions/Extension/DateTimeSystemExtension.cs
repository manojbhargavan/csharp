namespace System
{
    public static class DateTimeSystemExtension
    {
        public static string ToXmlDateTime(this DateTime dateTime)
        {
            return $"{dateTime:o}";
        }
    }
}