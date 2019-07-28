using System;
using System.Collections.Generic;

namespace Person.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetAllPersons();
        Person GetPerson(long id);
    }
}
