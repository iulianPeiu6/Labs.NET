using Data.Models;
using System.Collections.Generic;
using System.Linq;
using Vanguard;

namespace Data
{
    public class WeatherDataProcessor
    {
        public WeatherData GetRecordWithSmallestTemperatureSpread(IList<WeatherData> records)
        {
            Guard.ArgumentNotNullOrEmpty(records, nameof(records));

            var result = records.FirstOrDefault();
            var smallestTemperatureSpreed = result.MxT - result.MnT;

            foreach (var record in records)
            {
                var temperatureSpread = record.MxR - record.MnT;
                if (temperatureSpread < smallestTemperatureSpreed)
                {
                    smallestTemperatureSpreed = temperatureSpread;
                    result = record;
                }
            }

            return result;
        }
    }
}