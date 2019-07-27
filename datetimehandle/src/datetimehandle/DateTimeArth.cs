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

    }
}
