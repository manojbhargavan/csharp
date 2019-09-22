using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public class EventExample1 : IExample
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkComplete;

        public void RunExample()
        {
            DelegateExample1 delegateExample1 = new DelegateExample1();
            WorkPerformed += new WorkPerformedHandler(delegateExample1.WorkDone1);
            WorkPerformed += new WorkPerformedHandler(delegateExample1.WorkDone2);
            DoWork(10);
        }

        public void DoWork(int hours)
        {
            for (int i = 0; i < hours; i++)
            {
                Array values = Enum.GetValues(typeof(WorkType));
                Random random = new Random();
                WorkType randomWorkType = (WorkType)values.GetValue(random.Next(values.Length));
                OnWorkPerformed(random.Next(9), randomWorkType);
            }
            OnWorkCompleted();
        }

        private void OnWorkPerformed(int hours, WorkType workType)
        {
            if (WorkPerformed is WorkPerformedHandler del)
            {
                del(hours, workType);
            }
        }

        private void OnWorkCompleted()
        {
            if (WorkComplete is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
