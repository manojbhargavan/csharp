using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkDone(int hours, WorkType workType);
    public class Example1 : IExample
    {
        public void RunExample()
        {
            WorkDone workDoneHandler = new WorkDone(WorkDone1);
            workDoneHandler += WorkDone2;
            workDoneHandler(8, WorkType.Code);
            Document(WorkDone1);
            Document(WorkDone2);
        }

        private void Document(WorkDone delegateWork)
        {
            Console.WriteLine("Let me delegate this");
            delegateWork(8, WorkType.Document);
        }

        private void WorkDone2(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Done 1: Hours {hours}, Type {workType}");
        }

        private void WorkDone1(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Done 2: Hours {hours}, Type {workType}");
        }
    }
}
