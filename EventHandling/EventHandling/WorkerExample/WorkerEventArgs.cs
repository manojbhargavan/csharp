using System;

namespace EventHandling.WorkerExample
{
    public class WorkerEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
