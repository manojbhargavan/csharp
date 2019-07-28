using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Repository
{
    public abstract class StandardRepository : IPersonReaderRepository
    {
        public abstract List<Person> GetAllPersons();

        public Person GetPerson(long id)
        {
            return GetAllPersons().Where(u => u.Id == id).First();
        }
    }
}
