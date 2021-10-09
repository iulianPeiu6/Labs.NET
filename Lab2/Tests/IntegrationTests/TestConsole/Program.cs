﻿using System;
using DataProcessor;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunWeatherDataProcessorTest();
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
    }
}
