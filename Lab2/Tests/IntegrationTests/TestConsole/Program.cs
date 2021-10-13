﻿using System;
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

            var testFootballFile = @"..\..\..\..\..\DataTest\football.dat";

            var processor = new WeatherDataProcessor();
            var football_processor = new FootballDataProcessor();

            var records = processor.ReadRecords(testFile);
            var football_records = football_processor.ReadRecords(testFootballFile);
            foreach (var record in football_records)
            {
                Console.WriteLine($"{ record }");
            }

            Console.WriteLine("Am ajuns aici");

            /* foreach (var record in records)
             {
                 Console.WriteLine($"{ record }");
             }

             var recordWithSmallestTemperatureSpread = processor.GetRecordWithSmallestTemperatureSpread(records);
             Console.WriteLine(recordWithSmallestTemperatureSpread);
            */
        }
      

        public static void RunFootballDataProcessorTest()
        {

            var testFootballFile = @"..\..\..\..\..\DataTest\football.dat";

            var football_processor = new FootballDataProcessor();
            
            var records = football_processor.ReadRecords(testFootballFile);
            
            var football_records = football_processor.ReadRecords(testFootballFile);
            
            foreach (var record in football_records)
            {
                Console.WriteLine($"{ record }");
            }

            Console.WriteLine("Am ajuns aici");

        }

        public static void RunSoccerLeagueDataProcessorTest()
        {
            var testFootballFile = @"..\..\..\..\..\DataTest\football.dat";

            var soccer_league_processor = new SoccerLeagueDataProcessor();

            var records = soccer_league_processor.ReadRecords(testFootballFile);

            var soccer_league_records = soccer_league_processor.ReadRecords(testFootballFile);

            foreach (var record in soccer_league_records)
            {
                Console.WriteLine($"{ record }");
            }

            var recordWithSmallestDifferenceBetweenGoals = soccer_league_processor.GetRecordWithSmallestDifferenceForAgainstGoals(records);
            Console.WriteLine(recordWithSmallestDifferenceBetweenGoals);
        }
    }
}
