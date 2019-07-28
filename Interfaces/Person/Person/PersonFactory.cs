using System;
using System.Configuration;

namespace Person.Repository
{
    public static class PersonFactory
    {
        public static IPersonRepository GetPersonRepository()
        {
            string repositoryId = ConfigurationManager.AppSettings["Repository"];
            Type repositoryType = Type.GetType(repositoryId);
            object objectType = Activator.CreateInstance(repositoryType);
            IPersonRepository personRepository = objectType as IPersonRepository;
            return personRepository;
        }
    }
}
