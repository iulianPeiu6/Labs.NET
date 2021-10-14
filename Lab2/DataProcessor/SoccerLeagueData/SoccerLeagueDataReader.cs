using DataProcessor.Mappings;
using DataProcessor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataProcessor
{
    public class SoccerLeagueDataReader
    {
        public IList<SoccerLeagueData> ReadRecords(string filename, bool hasHeader = true)
        {
            var records = new List<SoccerLeagueData>();

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

        private SoccerLeagueData MapLineToRecord(string line)
        {
            var properties = line.Split(new char[] { '-', ',', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

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

            var record = new SoccerLeagueData
            {
                Team = properties[SoccerLeagueDataDefaultMapper.Team_Index],
                P = int.Parse(properties[SoccerLeagueDataDefaultMapper.P_Index]),
                W = int.Parse(properties[SoccerLeagueDataDefaultMapper.W_Index]),
                L = int.Parse(properties[SoccerLeagueDataDefaultMapper.L_Index]),
                D = int.Parse(properties[SoccerLeagueDataDefaultMapper.D_Index]),
                F = int.Parse(properties[SoccerLeagueDataDefaultMapper.P_Index]),
                A = int.Parse(properties[SoccerLeagueDataDefaultMapper.A_Index]),
                Pts = int.Parse(properties[SoccerLeagueDataDefaultMapper.Pts_Index])
            };

            return record;
        }
    }
}
