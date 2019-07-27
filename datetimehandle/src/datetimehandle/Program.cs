using System;
using System.Globalization;
using System.Linq;

namespace datetimehandle
{
    class Program
    {
        static void Main(string[] args)
        {
            Basics();
        }

        private static void Basics()
        {
            var dateTime = DateTime.Now;
            Console.WriteLine(
                $"Local: {dateTime}, " +
                $"AUS: {dateTime.GetConverted("E. Australia Standard Time")}\n");

            //Date Time Offset
            var dateTimeOffset = DateTimeOffset.Now;
            Console.WriteLine($"Local: {dateTimeOffset}\nTimeZones Matching Offset:\n{DateTimeOffset.Now.GetTimeZone().Aggregate((a, b) => $"{a}\n{b}") ?? "Not Found"}\n");
            var dateTimeOffset5 = dateTimeOffset.ToOffset(TimeSpan.FromHours(10));
            Console.WriteLine($"UTC+10: {dateTimeOffset5}\nTimeZones Matching Offset:\n{dateTimeOffset5.GetTimeZone().Aggregate((a, b) => $"{a}\n{b}") ?? "Not Found"}\n");
            var dateTimeOffset2 = dateTimeOffset.ToOffset(TimeSpan.FromHours(2));
            Console.WriteLine($"UTC+2: {dateTimeOffset2}\nTimeZones Matching Offset:\n{dateTimeOffset2.GetTimeZone().Aggregate((a, b) => $"{a}\n{b}") ?? "Not Found"}\n");

            //Parse
            var date = "9/10/2019 10:00:00 PM";
            Console.WriteLine($"Date String: {date}");
            Console.WriteLine($"Parse :{DateTime.Parse(date):dd MMM yyyy hh:mm:tt}");
            Console.WriteLine($"Parse Exact :{DateTime.ParseExact(date, "d/M/yyyy h:mm:ss tt", CultureInfo.InvariantCulture):dd MMM yyyy hh:mm:tt}");

            var dateVar = "2019-07-01 10:00:00 PM +02:00";
            Console.WriteLine($"Date String: {dateVar}");
            Console.WriteLine($"Parse :{DateTime.Parse(dateVar, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal)}");

            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings

            //Always use DateTimeOffset & UTCNow
            var dateTimeUtc = DateTimeOffset.UtcNow;
            Console.WriteLine($"\nUTC: {dateTimeUtc:o}, Local: {dateTimeUtc.ToLocalTime():o}");
        }
    }
}
