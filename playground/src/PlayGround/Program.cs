using PlayGround.Common;
using System;
using PlayGround.WorldPopulation;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the part to run\n1 --> Array\n2 --> List");
            string choice = Console.ReadLine();
            string worldPopFile = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\World_population.csv";
            #region World Population - Array (1)
            if (choice == "1")
            {
                Console.Write("How many Countries whould be retrived: ");
                int count = -1;
                if (!int.TryParse(Console.ReadLine(), out count))
                    count = 10;

                var data = (new ParseCsv()).GetRecordsArray<WorldPopulationModel>(worldPopFile, count, "Year_2020");

                Console.WriteLine("Array Countries");
                foreach(var curCountry in data)
                {
                    Console.WriteLine($"{curCountry.Year_2020:0 000 000}: {curCountry.Country}");
                }
            }
            #endregion

            #region World Population - List (2)
            if(choice == "2")
            {
                var data = (new ParseCsv()).GetRecordsList<WorldPopulationModel>(worldPopFile, 100, "Year_2020");

                Console.WriteLine("Array List");
                foreach (var curCountry in data)
                {
                    Console.WriteLine($"{curCountry.Year_2020:0 000 000}: {curCountry.Country}");
                }
            }
            #endregion
        }
    }
}
