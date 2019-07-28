using Person.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Person.TestMock
{
    public class TestMockRepository : StandardRepository
    {
        public override List<Repository.Person> GetAllPersons()
        {
            List<Repository.Person> mockData = new List<Repository.Person>() {
                new Repository.Person(){ UserId = "1", Id = 1, Title = "Jamuna Pyari", Completed = true},
                new Repository.Person(){ UserId = "2", Id = 2, Title = "Oceans 12", Completed = false},
                new Repository.Person(){ UserId = "3", Id = 3, Title = "Friends", Completed = true}
            };
            return mockData;
        }
    }
}
