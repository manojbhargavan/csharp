using System;
using System.Collections.Generic;

namespace Person.Repository
{
    public interface IPersonReaderRepository
    {
        List<Person> GetAllPersons();
        Person GetPerson(long id);
    }
}
