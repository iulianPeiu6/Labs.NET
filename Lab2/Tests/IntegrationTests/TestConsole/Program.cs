using System;
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

            var processor = new WeatherDataProcessor();
            var records = processor.ReadRecords(testFile);

            foreach (var record in records)
            {
                Console.WriteLine($"{ record }");
            }

            var recordWithSmallestTemperatureSpread = processor.GetRecordWithSmallestTemperatureSpread(records);
            Console.WriteLine(recordWithSmallestTemperatureSpread);
        }
    }
}
