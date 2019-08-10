using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>()
            {
                new Movie() { Title = "The Dark Knight", Rating = 8.9f, Year = 2008},
                new Movie() { Title = "The Queens Speech", Rating = 8.0f, Year = 2010},
                new Movie() { Title = "Casablanca", Rating = 8.5f, Year = 1942},
                new Movie() { Title = "Star Wars V", Rating = 8.7f, Year = 1980}
            };

            var after2000 = movies.Where(m => m.Year > 2000);

            foreach (var item in after2000)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("*****");
            var after2000F = movies.Filter(m => m.Year > 2000);

            foreach (var item in after2000F)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
