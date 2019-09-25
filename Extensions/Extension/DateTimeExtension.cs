using System;

namespace Extension
{
    public static class DateTimeExtension
    {
        public static int TimeId(this DateTime dateTime)
        {
            int timeId = 0;
            string timeIdString = $"{dateTime:yyyyMMdd}";
            return int.TryParse(timeIdString, out timeId) ? timeId : -1;
        }

        public static string LegacyFormat(this DateTime dateTime)
        {
            return (dateTime.Year > 1930) ? $"1{dateTime:yyMMdd}" : $"0{dateTime:yyMMdd}";
        }
    }
}
