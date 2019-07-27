using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimehandle
{
    public static class DateExtensions
    {
        internal static string GetDifferenceString(this DateTimeOffset dateTimeFrom, DateTimeOffset dateTimeTo)
        {
            TimeSpan timeSpan = dateTimeTo.Subtract(dateTimeFrom);
            return GetDifferenceStringTimeSpan(timeSpan);
        }

        internal static string GetMultipliedDifferenceString(this DateTimeOffset dateTimeFrom, DateTimeOffset dateTimeTo, double factor)
        {
            TimeSpan timeSpan = dateTimeTo.Subtract(dateTimeFrom);
            return GetDifferenceStringTimeSpan(timeSpan.Multiply(factor));
        }

        private static string GetDifferenceStringTimeSpan(TimeSpan timeSpan)
        {
            long days = timeSpan.Days;
            long hours = timeSpan.Hours;
            long minutes = timeSpan.Minutes;
            long seconds = timeSpan.Seconds;
            long millSeconds = timeSpan.Milliseconds;

            return $"{days.TimePluralize("Day")} {hours.TimePluralize("Hour")} " +
                $"{minutes.TimePluralize("Minute")} {seconds.TimePluralize("Second")} {millSeconds.TimePluralize("Millisecond")}";
        }

        private static string TimePluralize(this long value, string type)
        {
            return $"{value} {type}{(value > 1 ? "s" : "")}";
        }

        internal static bool IsBetween(this DateTimeOffset dateTime, DateTimeOffset dateTimeFrom, DateTimeOffset dateTimeTo)
        {
            return dateTime.ToUniversalTime() >= dateTimeFrom.ToUniversalTime() && dateTime.ToUniversalTime() <= dateTimeTo.ToUniversalTime();
        }
    }
}
