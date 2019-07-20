using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;

namespace PlayGround.Common
{
    public class ParseCsv
    {
        public T[] GetRecordsArray<T>(string fileName, int count, string sortBy)
        {
            if (!File.Exists(fileName))
            {
                throw new IOException($"File {fileName} not found");
            }

            using (var reader = new StreamReader(fileName))
            {
                using (var csv = new CsvReader(reader))
                {
                    var initList = csv.GetRecords<T>().ToList();
                    var recordsOrdered = OrderByField<T>(initList.AsQueryable(), sortBy, false);
                    var records = recordsOrdered.Take(count).ToArray();
                    return records;
                }
            }

        }

        private IQueryable<T> OrderByField<T>(IQueryable<T> q, string SortField, bool Ascending)
        {
            var param = Expression.Parameter(typeof(T), "p");
            var prop = Expression.Property(param, SortField);
            var exp = Expression.Lambda(prop, param);
            string method = Ascending ? "OrderBy" : "OrderByDescending";
            Type[] types = new Type[] { q.ElementType, exp.Body.Type };
            var mce = Expression.Call(typeof(Queryable), method, types, q.Expression, exp);
            return q.Provider.CreateQuery<T>(mce);
        }
    }
}
