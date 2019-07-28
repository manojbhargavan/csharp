using System;
using System.Configuration;

namespace Person.Repository
{
    public static class PersonFactory
    {
        public static IPersonReaderRepository GetPersonRepository()
        {
            string repositoryId = ConfigurationManager.AppSettings["Repository"];
            Type repositoryType = Type.GetType(repositoryId);
            object objectType = Activator.CreateInstance(repositoryType);
            IPersonReaderRepository personRepository = objectType as IPersonReaderRepository;
            return personRepository;
        }
    }
}
