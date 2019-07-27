using System;
using System.Collections.Generic;

namespace datetimehandle
{
    public static class Basic
    {
        internal static DateTime GetConverted(this DateTime dateTime, string timeZone)
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            try
            {
                return TimeZoneInfo.ConvertTime(dateTime, timeZoneInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static List<string> GetTimeZone(this DateTimeOffset dateTime)
        {
            List<string> timeZoneDisplayName = new List<string>();
            foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                if(timeZone.GetUtcOffset(dateTime) == dateTime.Offset)
                {
                    timeZoneDisplayName.Add(timeZone.DisplayName);
                }
            }
            return timeZoneDisplayName;
        }

    }
}