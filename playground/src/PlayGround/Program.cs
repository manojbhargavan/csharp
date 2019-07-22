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
            Console.WriteLine("Enter the part to run\n1 --> Array\n2 --> List\n3 --> Key Value Pair\n4 --> Pop By Region");
            string choice = Console.ReadLine();
            string worldPopFile = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\World_population.csv";
            string worldPopFileMin = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Pop by Largest Final.csv";
            #region World Population - Array (1)
            if (choice == "1")
            {
                Console.Write("How many Countries whould be retrived: ");
                int count = -1;
                if (!int.TryParse(Console.ReadLine(), out count))
                    count = 10;

                var data = (new ParseCsv()).GetRecordsArray<WorldPopulationModel>(worldPopFile, count, "Year_2020");

                Console.WriteLine("Array Countries");
                Console.Write("Please enter the number of countries to display, something else to quit: ");
                int number = 10;
                if (!(int.TryParse(Console.ReadLine(), out number) && number > 0))
                {
                    Console.WriteLine("Bad input defaulting to 10");
                }

                for (int i = 0; i < data.Length; i++)
                {
                    if (i != 0 && i % number == 0)
                    {
                        Console.WriteLine("Press enter to continue, anything else to exit");
                        if (!(Console.ReadLine() == ""))
                        {
                            break;
                        }
                    }
                    var curCountry = data[i];
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
                bool runLoop = true;
                int startIndex = 0;
                do
                {
                    Console.Write("Please enter the number of countries to display, something else to quit: ");
                    int number = 10;
                    if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                    {
                        for (int loopVar = startIndex; loopVar < startIndex + number && loopVar < data.Count; loopVar++)
                        {
                            var curCountry = data[loopVar];
                            Console.WriteLine($"{loopVar + 1} --> {curCountry.Year_2020:0 000 000}: {curCountry.Country}");
                        }
                        startIndex += number;
                        if (startIndex >= data.Count)
                        {
                            Console.WriteLine("Countries list exausted..");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Exit program.");
                        break;
                    }



                } while (runLoop);
                Console.WriteLine($"{data.Count} Countries.");
            }
            #endregion

            #region Key Value Pair (3)
            if (choice == "3")
            {
                var data = (new ParseCsv()).GetRecordsDictionary<WorldPopulationModel>(worldPopFile, 100,
                    "Year_2020", "Countrycode");

                Console.WriteLine("Enter the Country Code: ");
                string code = Console.ReadLine();

                WorldPopulationModel worldPopulationModel;
                if (data.TryGetValue(code, out worldPopulationModel))
                {
                    Console.WriteLine($"Name: {worldPopulationModel.Country}, Population: {worldPopulationModel.Year_2020}");
                }
                else
                {
                    Console.WriteLine($"Unable to get details for the country code {code}");
                }

            }
            #endregion

            #region Pop By Continent
            if (choice == "4")
            {
                var popByRegion = (new ParseCsv()).GetPopulationByRegion<PopulationMinModel>(worldPopFileMin, "Population_2017", "Continent");
                Console.Write($"Enter a region to continue --> {popByRegion.Keys.Aggregate((cur, next) => cur + ", " + next)}: ");
                string region = Console.ReadLine();
                if(popByRegion.ContainsKey(region))
                {
                    foreach(var cur in popByRegion[region])
                    {
                        Console.WriteLine($"{cur.Population_2017:000 000 000 000}\t{cur.Continent}\t{cur.Country_Code}\t{cur.Country_Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Hard luck spelling the region bud.");
                }
            }
            #endregion
        }
    }
}
