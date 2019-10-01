using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public static class Extensions
    {
        public static TimeSpan GetDuration(this DateTime startTime, DateTime endTime)
        {
            return endTime - startTime;
        }

        public static int GetDurationInSeconds(this DateTime startTime, DateTime endTime)
        {
            return startTime.GetDuration(endTime).Seconds;
        }

        public static int GetDurationInMilliSeconds(this DateTime startTime, DateTime endTime)
        {
            return startTime.GetDuration(endTime).Milliseconds;
        }

    }
}
