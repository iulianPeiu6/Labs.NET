using System;
using DataProcessor;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunWeatherDataProcessorTest();
            RunSoccerLeagueDataProcessorTest();
        }
        public static void RunWeatherDataProcessorTest()
        {
            var testFile = @"..\..\..\..\..\DataTest\weather.dat";

            var processor = new WeatherDataProcessor();
            var reader = new WeatherDataReader();
            var records = reader.ReadRecords(testFile);

            foreach (var record in records)
            {
                Console.WriteLine($"{ record }");
            }

            var recordWithSmallestTemperatureSpread = processor.GetRecordWithSmallestTemperatureSpread(records);
            Console.WriteLine(recordWithSmallestTemperatureSpread);
        }

        public static void RunSoccerLeagueDataProcessorTest()
        {
            var testFootballFile = @"..\..\..\..\..\DataTest\football.dat";

            var soccerLeagueProcessor = new SoccerLeagueDataProcessor();
            var soccerLeagueReader = new SoccerLeagueDataReader();

            var records = soccerLeagueReader.ReadRecords(testFootballFile);

            foreach (var record in records)
            {
                Console.WriteLine($"{ record }");
            }

            var recordWithSmallestDifferenceBetweenGoals = soccerLeagueProcessor.GetRecordWithSmallestDifferenceForAgainstGoals(records);
            Console.WriteLine(recordWithSmallestDifferenceBetweenGoals);
        }
    }
}
