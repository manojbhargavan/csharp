using Employee.Definations;
using GenericObject.CsvReader;
using System;
using System.Configuration;

namespace GenericObjecRepos
{
    public class ObjectFactory
    {
        public static IObjectReader<T> GetObjectReader<T>(string typeString)
        {
            switch (typeString)
            {
                case "CSV": return new GenericCsvReaderRepository<T>();
                default: return null;
            }
        }
    }
}
