using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WhatAreYourWorkingOn(int hours);

    public class Example2 : IExample
    {
        public void RunExample()
        {
            WhatAreYourWorkingOn whatAreYourWorkingOnDelegate = Coding;
            whatAreYourWorkingOnDelegate += UTC;
            whatAreYourWorkingOnDelegate += QA;
            whatAreYourWorkingOnDelegate(8);
        }

        private void Coding(int hrs)
        {
            Console.WriteLine($"I am {WorkType.Code}ing its about {hrs} hours");
        }

        private void UTC(int hrs)
        {
            Console.WriteLine($"I am {WorkType.UnitTest}ing its about {hrs} hours");
        }

        private void QA(int hrs)
        {
            Console.WriteLine($"{WorkType.QA} is about to start in {hrs} hours");
        }
    }
}
