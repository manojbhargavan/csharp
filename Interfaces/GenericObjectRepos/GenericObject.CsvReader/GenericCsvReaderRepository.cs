using Employee.Definations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GenericObject.CsvReader
{
    public class GenericCsvReaderRepository<T> : IObjectReader<T>
    {
        public string ConnectionString { get; set; }

        public IEnumerable<T> GetObjects()
        {
            using (var reader = new StreamReader(ConnectionString))
            using (var csv = new CsvHelper.CsvReader(reader))
            {
                var records = csv.GetRecords<T>();
                return records;
            }
        }

        public T GetObject(long ObjectId, string propertyToLookup)
        {
            var result = GetObjects();
            var prop = result.GetType().GetProperty(propertyToLookup);
            return result.Where(o => prop.GetValue(o) == (object)ObjectId).First();
        }
    }
}
