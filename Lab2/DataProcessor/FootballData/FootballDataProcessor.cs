using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessor.Models;
using DataProcessor.FootballData;
using DataProcessor.FootballData.Mappings;
using DataProcessor.Mappings;

namespace DataProcessor
{
    public class FootballDataProcessor
    {

        public IList<FootballData.Models.FootballData> ReadRecords(string filename, bool hasHeader = true)
        {
            var records = new List<FootballData.Models.FootballData>();

            var bulkContent = File.ReadAllText(filename);

            var bulkLines = bulkContent.Split("\n").ToList();

            if (hasHeader)
            {
                bulkLines.RemoveAt(0);
            }

            foreach (var line in bulkLines)
            {
                var mappedRecord = MapLineToRecord(line);
                if (mappedRecord != null)
                {
                    records.Add(mappedRecord);
                }
            }

            return records;

        }


        private FootballData.Models.FootballData MapLineToRecord(string line)
        {
            var properties = line.Split(new char[]{ ',' ,'\n'}, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < properties.Length; j++)
            {
                if (properties[j].Equals("null"))
                {
                    properties[j] = null;
                }
            }

            if (properties.Length == 0)
            {
                return null; 
            }

            var record = new FootballData.Models.FootballData
            {
                Team = properties[FootballDataDefaultMapper.Team_Index],

                P = int.Parse(properties[FootballDataDefaultMapper.P_Index]),
                W = int.Parse(properties[FootballDataDefaultMapper.W_Index]),
                L = int.Parse(properties[FootballDataDefaultMapper.L_Index]),
                D = int.Parse(properties[FootballDataDefaultMapper.D_Index]),
                F = int.Parse(properties[FootballDataDefaultMapper.P_Index]),
                A = int.Parse(properties[FootballDataDefaultMapper.A_Index]),



            };

            return record;

        }








    }
}
