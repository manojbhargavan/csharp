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
            DateTimeArithmetic();

        }

        private static void DateTimeArithmetic()
        {
            Console.Write("\n---------Arithmetic-----------");

            DateTimeArth.TimeSpanExample(new TimeSpan(20, 100, 200));
            DateTimeArth.TimeSpanExample(new TimeSpan(25, 100, 200));
            DateTimeArth.TimeSpanExample(new TimeSpan(400, 100, 200));
            string timeFromString = "2019-07-01 10:00:00 PM +02:00";
            string timeToString = "2019-07-03 23:11:45.899 PM +02:00";
            DateTimeOffset timeFrom = DateTimeOffset.Parse(timeFromString);
            DateTimeOffset timeTo = DateTimeOffset.Parse(timeToString);
            Console.WriteLine($"\nTime From: {timeFromString}, Time To: {timeToString}\nTime Between: {timeFrom.GetDifferenceString(timeTo)}");
            Console.WriteLine($"Multiplied By 2!!: {timeFrom.GetMultipliedDifferenceString(timeTo, 2)}");
            DateTimeOffset contractStart = DateTimeOffset.Parse("2020-02-29 12:00:00 AM +00:00");
            Console.WriteLine($"Contract Extended Till: {DateTimeArth.ExtendContract(contractStart, 1)}");

            Console.WriteLine("------------------------------");

        }

        private static void Basics()
        {
            Console.WriteLine("---------Basics-----------");
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
            Console.WriteLine("--------------------------");
        }
    }
}
