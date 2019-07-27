using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetimehandle
{
    public static class DateTimeArth
    {
        internal static DateTimeOffset ExtendContract(DateTimeOffset dateTimeOffsetFrom, int extendBy)
        {
            DateTimeOffset dateTimeNew = dateTimeOffsetFrom.AddMonths(1).AddTicks(-1);
            return new DateTimeOffset(dateTimeNew.Year,
                dateTimeNew.Month,
                DateTime.DaysInMonth(dateTimeNew.Year, dateTimeNew.Month),
                23, 59, 59, dateTimeNew.Offset);
        }

        internal static void TimeSpanExample(TimeSpan timeSpan)
        {

            Console.WriteLine($"\nTime Span: {timeSpan} -->\n{timeSpan.Days} Day{(timeSpan.Days > 1 ? "s" : "")} " +
                $"{timeSpan.Hours} Hour{(timeSpan.Hours > 1 ? "s" : "")} {timeSpan.Minutes} " +
                $"Minute{(timeSpan.Minutes > 1 ? "s" : "")} {timeSpan.Seconds} Second{(timeSpan.Days > 1 ? "s" : "")}.");
            Console.WriteLine($"Total Days: {timeSpan.TotalDays}, Total Hours: {timeSpan.TotalHours}, Total Minutes: {timeSpan.TotalMinutes}");
        }

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

    }
}
