using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandling.WorkerExample
{
    public class Worker
    {
        public event EventHandler<WorkerEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 1; i <= hours; i++)
            {
                Thread.Sleep(1000);
                OnWorkPerformed(i, workType);
            }
            OnWorkCompleted();
        }

        private void OnWorkPerformed(int hours, WorkType workType)
        {
            WorkPerformed(this, new WorkerEventArgs { Hours = hours, WorkType = workType });
        }

        private void OnWorkCompleted()
        {
            WorkCompleted(this, new EventArgs());
        }
    }
}
