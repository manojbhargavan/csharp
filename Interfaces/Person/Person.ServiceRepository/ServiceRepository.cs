using Newtonsoft.Json;
using Person.Repository;
using System;
using System.Collections.Generic;
using System.Net;

namespace Person.Service
{
    public class ServiceRepository : StandardRepository
    {
        public override List<Repository.Person> GetAllPersons()
        {
            WebClient client = new WebClient();
            string response = client.DownloadString("https://jsonplaceholder.typicode.com/todos");

            var personData = JsonConvert.DeserializeObject<List<Repository.Person>>(response);
            return personData;
        }

    }
}
