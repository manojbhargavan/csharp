using System;
using System.Collections.Generic;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Type> examples = new List<Type>
            {
                typeof(DelegateExample1),
                typeof(DelegateExample2),
                typeof(DelegateExample3),
                typeof(DelegatePlugin),
                typeof(EventExample1),
                typeof(EventExample2)
            };

            examples.ForEach(e => Execute(e));
        }

        private static void Execute(Type e)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Running example for {e.Name}");
            Console.WriteLine("-------------------------------");
            RunExamples(e);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

        internal static void RunExamples(Type example)
        {
            ((IExample)Activator.CreateInstance(example)).RunExample();
        }
    }
}
