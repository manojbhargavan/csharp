using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class DelegateExample3 : IExample
    {
        public delegate int PerformAction(WorkType workType, int hours);

        public void RunExample()
        {
            PerformAction performAction = PerformAction1;
            performAction += PerformAction2;
            performAction += PerformAction3;
            Console.WriteLine(
            performAction(WorkType.Deploy, 10));
        }

        private int PerformAction2(WorkType workType, int hours)
        {
            Console.WriteLine($"Perform Action 2: {workType}");
            return hours + 2;
        }

        private int PerformAction3(WorkType workType, int hours)
        {
            Console.WriteLine($"Perform Action 3: {workType}");
            return hours + 3;
        }

        private int PerformAction1(WorkType workType, int hours)
        {
            Console.WriteLine($"Perform Action 1: {workType}");
            return hours + 1;
        }
    }
}
