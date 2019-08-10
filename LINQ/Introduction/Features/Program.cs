using System;
using System.Collections.Generic;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //Foundations
            IEnumerable<Employee> devs = new Employee[]
                {
                    new Employee() {Id = 1, Name = "Manoj" },
                    new Employee() {Id = 2, Name = "Nandan"  }
                };
            IEnumerable<Employee> sales = new List<Employee>
            {
                new Employee() {Id = 3,Name="Saranya"}
            };

            IEnumerator<Employee> enumerator = devs.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.Id,5}: {enumerator.Current.Name,-10}");
            }
            Console.WriteLine(devs.CountKaro());

            //Funct
            Func<int, int> sqr = Square;
            Console.WriteLine(sqr(10));
        }

        private static int Square(int arg)
        {
            return arg * arg;
        }
    }
}
