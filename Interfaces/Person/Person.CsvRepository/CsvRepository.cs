using CsvHelper;
using Person.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Person.Csv
{
    public class CsvRepository : StandardRepository
    {
        public override List<Repository.Person> GetAllPersons()
        {
            using (var reader = new StreamReader(".\\Data\\persondata.csv"))
            {
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.GetRecords<Repository.Person>();
                    return records.ToList();
                }
            }
        }
    }
}
