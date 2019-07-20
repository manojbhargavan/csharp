using PlayGround.Common;
using System;
using PlayGround.WorldPopulation;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            #region World Population - 1
            if (args[0] == "1")
            {
                string worldPopFile = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\World_population.csv";

                var data = (new ParseCsv()).GetRecordsArray<WorldPopulationModel>(worldPopFile, 10, "Year_2020");
            }
            #endregion
        }
    }
}
