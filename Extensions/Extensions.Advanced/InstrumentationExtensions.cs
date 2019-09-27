using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Advanced
{
    public static class InstrumentationExtensions
    {
        private static Dictionary<Guid, Stopwatch> RunningInstances;

        public static void StartPrecise(this Instrumentation instrumentation)
        {
            if (RunningInstances == null)
                RunningInstances = new Dictionary<Guid, Stopwatch>();
            RunningInstances.Add(instrumentation.Id, Stopwatch.StartNew());
        }

        public static decimal GetPreciseElapsedTimeAndStop(this Instrumentation instrumentation)
        {
            var result = RunningInstances[instrumentation.Id].ElapsedMilliseconds;
            RunningInstances[instrumentation.Id].Stop();
            RunningInstances.Remove(instrumentation.Id);
            return result;
        }
    }
}
