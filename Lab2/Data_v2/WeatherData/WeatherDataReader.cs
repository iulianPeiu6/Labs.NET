using Data_v2.Mappings;
using Data_v2.Models;
using System;
using System.Collections.Generic;

namespace Data_v2
{
    public class WeatherDataReader : DataReaderBase
    {
        public IList<WeatherData> ReadRecords(string filename, bool hasHeader = true)
        {
            var records = GetLines<WeatherData>(filename, (string line) => MapLineToRecord(line), hasHeader);

            return records;
        }

        private WeatherData MapLineToRecord(string line)
        {
            var properties = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].Equals("null"))
                {
                    properties[i] = null;
                }
            }

            if (properties.Length == 0)
            {
                //empty line - ignored
                return null;
            }
            if (properties[WeatherDataDefaultMapper.Dy_Index] == "mo")
            {
                //mean line - ignored
                return null;
            }
            var record = new WeatherData
            {
                Dy = int.Parse(properties[WeatherDataDefaultMapper.Dy_Index]),
                MxT = int.Parse(properties[WeatherDataDefaultMapper.MxT_Index]),
                MnT = int.Parse(properties[WeatherDataDefaultMapper.MnT_Index]),
                AvT = int.Parse(properties[WeatherDataDefaultMapper.AvT_Index]),
                //HDDay = int.Parse(properties[WeatherDataDefaultMapper.HDDay_Index]),
                //AvDP = decimal.Parse(properties[WeatherDataDefaultMapper.AvDP_Index]),
                //HrP1 = int.Parse(properties[WeatherDataDefaultMapper.HrP1_Index]),
                //TPcpn = decimal.Parse(properties[WeatherDataDefaultMapper.TPcpn_Index]),
                //WxType = properties[WeatherDataDefaultMapper.WxType_Index],
                //PDir = int.Parse(properties[WeatherDataDefaultMapper.PDir_Index]),
                //AvSp = decimal.Parse(properties[WeatherDataDefaultMapper.AvSp_Index]),
                //Dir = int.Parse(properties[WeatherDataDefaultMapper.Dir_Index]),
                //MxS = int.Parse(properties[WeatherDataDefaultMapper.MxS_Index]),
                //SkyC = decimal.Parse(properties[WeatherDataDefaultMapper.SkyC_Index]),
                //MxR = int.Parse(properties[WeatherDataDefaultMapper.MxR_Index]),
                //MnR = int.Parse(properties[WeatherDataDefaultMapper.MnR_Index]),
                //AvSLP = decimal.Parse(properties[WeatherDataDefaultMapper.AvSLP_Index])
            };
            return record;
        }
    }
}