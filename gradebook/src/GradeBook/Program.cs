using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Manoj's Grade Book");
            string input = "";
            do
            {
                Console.Write("Please enter a Grade, Q/q to Exit: ");
                input = Console.ReadLine();
                double inputD;
                if (double.TryParse(input, out inputD))
                {
                    book.AddGrade(inputD);
                }
                else
                {
                    if (input.ToUpper().Trim() != "Q")
                        Console.WriteLine("Not numeric");
                }
            } while (input.ToUpper().Trim() != "Q");

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Min}");
            Console.WriteLine($"The highest grade is {stats.Max}");
            Console.WriteLine($"The Average grade is {stats.Average}");
            Console.WriteLine($"The Letter grade is {stats.LetterGrade}");
        }
    }
}
