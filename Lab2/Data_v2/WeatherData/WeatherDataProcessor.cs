using Data_v2.Models;
using System.Collections.Generic;

namespace Data_v2
{
    public class WeatherDataProcessor : DataProcessorBase
    {
        public WeatherData GetRecordWithSmallestTemperatureSpread(IList<WeatherData> records)
        {
            var result = GetRecordWithSmallestSpreadBetween<WeatherData>(records, nameof(WeatherData.MxT), nameof(WeatherData.MnT));

            return result;
        }
    }
}