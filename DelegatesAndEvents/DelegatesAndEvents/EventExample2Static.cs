using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public static class EventExample2Static
    {
        public static void EventExample2_WorkCompleted2(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed 2");
        }

        public static void EventExample2_WorkCompleted1(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed 1");
        }

        public static void EventExample2_WorkPerformed3(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Event Called 3: Worked on {e.WorkType} for {e.Hours}");
        }

        public static void EventExample2_WorkPerformed2(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Event Called 2: Worked on {e.WorkType} for {e.Hours}");
        }

        public static void EventExample2_WorkPerformed1(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Event Called 1: Worked on {e.WorkType} for {e.Hours}");
        }
    }
}
