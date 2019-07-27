using System;

namespace datetimehandle
{
    public static class Basic
    {
        public static DateTime GetDateTimeNowGivenTimeZone(DateTime dateTime, string timeZone)
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            DateTime timeZonesDateTime;
            try
            {
                timeZonesDateTime = TimeZoneInfo.ConvertTime(dateTime, timeZoneInfo);
                return timeZonesDateTime;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}