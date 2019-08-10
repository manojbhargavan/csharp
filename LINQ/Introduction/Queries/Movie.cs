using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    public class Movie
    {
        int _year;
        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year
        {
            get
            {
                Console.WriteLine($"Returning {_year} for {Title}");
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Title,-20} Year: {Year,-5} & Rating: {Rating}";
        }

    }
}
