using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = ProcessFile("fuel.csv");
            //cars.Print();
            Console.WriteLine("***\nMost Efficient Cars");
            //Fuel Eff Car
            cars.OrderByDescending(c => c.Combined).ThenBy(c => c.Name).Take(10).Print();
            Console.WriteLine("***\nLeast Efficient Cars");
            (from car in cars orderby car.Combined, car.Name select car).Take(10).Print();
            Console.WriteLine("***\nMost Efficient Car - BMW 2016");
            var bmwTopCar = cars.Where(c => c.Manufacturer.ToUpper() == "BMW" && c.Year == 2016)
                .OrderByDescending(c => c.Combined)
                .ThenBy(c => c.Name)
                .First();
            Console.WriteLine(bmwTopCar.ToString());
            //All Any Contains
            Console.WriteLine("***\nAny");
            Console.WriteLine(cars.Any());
            Console.WriteLine("***\nAny Ford");
            Console.WriteLine(cars.Any(c => c.Manufacturer == "Ford"));
            Console.WriteLine("***\nAll Ford");
            Console.WriteLine(cars.All(c => c.Manufacturer == "Ford"));

        }

        private static List<Car> ProcessFile(string path)
        {
            //return File.ReadAllLines(path)
            //    .Skip(1)
            //    .Where(line => line.Length > 1)
            //    .Select(Car.ParseFromCsv)
            //    .ToList();

            //return (from line in File.ReadAllLines(path).Skip(1)
            //        where line.Length >= 1
            //        select Car.ParseFromCsv(line)).ToList();

            return File.ReadAllLines(path)
                .Skip(1)
                .Where(l => l.Length > 1)
                .ToCar().ToList();

        }
    }
}
