using GenericObjecRepos;
using System;
using System.Collections.Generic;

namespace EmployeeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee.Definations.IObjectReader<Model.Employee> repo = 
                ObjectFactory.GetObjectReader<Model.Employee>("CSV");
            repo.ConnectionString = ".\\Data\\Employee.csv";
            IEnumerable<Model.Employee> data = repo.GetObjects();
            var enumerator = data.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var curE = enumerator.Current;
                Console.WriteLine(curE.ToString());
            }
        }
    }
}
