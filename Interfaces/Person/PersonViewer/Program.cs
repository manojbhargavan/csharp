using Person.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PersonViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var personRepo = PersonFactory.GetPersonRepository();
            IEnumerable<Person.Repository.Person> personEnumerable = personRepo.GetAllPersons();

            Console.WriteLine("Data from repository");
            Console.WriteLine($"Repository Type {personRepo.GetType()}");
            Console.WriteLine($"Count: {personEnumerable.Count()}");
            Console.WriteLine($"------------------------DATA--------------------------");
            foreach (var person in personEnumerable)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine($"------------------------DATA--------------------------");
            Console.WriteLine($"{personRepo.GetPerson(2).ToString()}");

        }         
    }
}
