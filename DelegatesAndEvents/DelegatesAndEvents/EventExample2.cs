using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class EventExample2 : IExample
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void RunExample()
        {
            WorkPerformed += EventExample2Static.EventExample2_WorkPerformed1;
            WorkPerformed += EventExample2Static.EventExample2_WorkPerformed2;
            WorkPerformed += EventExample2Static.EventExample2_WorkPerformed3;
            WorkCompleted += EventExample2Static.EventExample2_WorkCompleted1;
            WorkCompleted += EventExample2Static.EventExample2_WorkCompleted2;
            for (int i = 0; i < 10; i++)
            {
                Array values = Enum.GetValues(typeof(WorkType));
                Random random = new Random();
                WorkType randomWorkType = (WorkType)values.GetValue(random.Next(values.Length));
                OnWorkPerformed(this, new WorkPerformedEventArgs(random.Next(9), randomWorkType));
            }
            OnWorkCompleted();
        }



        private void OnWorkPerformed(object sender, WorkPerformedEventArgs workPerformedEventArgs)
        {
            if (WorkPerformed is EventHandler<WorkPerformedEventArgs> del)
            {
                del(sender, workPerformedEventArgs);
            }
        }

        private void OnWorkCompleted()
        {
            if (WorkCompleted is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
