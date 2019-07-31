using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Definations
{
    public interface IObjectReader<T>
    {
        string ConnectionString { get; set; }
        IEnumerable<T> GetObjects();
        T GetObject(long ObjectId, string propertyToLookup);
    }
}
