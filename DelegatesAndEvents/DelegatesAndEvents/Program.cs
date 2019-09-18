using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            RunExamples(typeof(Example1));
            Console.WriteLine("*******************");
            RunExamples(typeof(Example2));
        }

        internal static void RunExamples(Type example)
        {
            ((IExample)Activator.CreateInstance(example)).RunExample();
        }
    }
}
