using PlayGround.Common;
using System;
using PlayGround.WorldPopulation;
using System.Linq;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the part to run\n1 --> Array\n2 --> List\n3 --> Key Value Pair");
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
                foreach (var curCountry in data)
                {
                    Console.WriteLine($"{curCountry.Year_2020:0 000 000}: {curCountry.Country}");
                }
            }
            #endregion

            #region World Population - List (2)
            if (choice == "2")
            {
                var data = (new ParseCsv()).GetRecordsList<WorldPopulationModel>(worldPopFile, 100, "Year_2020");
                WorldPopulationModel lilliput = new WorldPopulationModel()
                {
                    Country = "Lilliput",
                    Countrycode = "LIL",
                    Year_2020 = 200000
                };


                int insertIndex = data.FindIndex(d => d.Year_2020 < lilliput.Year_2020);
                data.Insert(insertIndex, lilliput);


                Console.WriteLine("List Countries");
                foreach (var curCountry in data)
                {
                    Console.WriteLine($"{curCountry.Year_2020:0 000 000}: {curCountry.Country}");
                }
                Console.WriteLine($"{data.Count} Countries.");
            }
            #endregion

            #region Key Value Pair
            if (choice == "3")
            {
                var data = (new ParseCsv()).GetRecordsDictionary<WorldPopulationModel>(worldPopFile, 100, 
                    "Year_2020", "Countrycode");

                Console.WriteLine("Enter the Country Code: ");
                string code = Console.ReadLine();

                WorldPopulationModel worldPopulationModel;
                if(data.TryGetValue(code, out worldPopulationModel))
                {
                    Console.WriteLine($"Name: {worldPopulationModel.Country}, Population: {worldPopulationModel.Year_2020}");
                }
                else
                {
                    Console.WriteLine($"Unable to get details for the country code {code}");
                }

            }
            #endregion
        }
    }
}
