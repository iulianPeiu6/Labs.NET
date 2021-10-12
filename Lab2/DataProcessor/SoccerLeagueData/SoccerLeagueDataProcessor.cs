using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using DataProcessor.Mappings;
using DataProcessor.Models;
using Vanguard;

namespace DataProcessor
{
    public class SoccerLeagueDataProcessor
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
        public SoccerLeagueData GetRecordWithSmallestDifferenceForAgainstGoals(IList<SoccerLeagueData> records)
        {
            Guard.ArgumentNotNullOrEmpty(records, nameof(records));

            var result = records.FirstOrDefault();
            var smallestDifferenceForAgainstGoals= result.F - result.A;

            foreach (var record in records)
            {
                var smallestDifferenceGoals = record.F - record.A;
                if (smallestDifferenceGoals < smallestDifferenceForAgainstGoals)
                {
                    smallestDifferenceForAgainstGoals = smallestDifferenceGoals;
                    result = record;
                }
            }

            return result;
        }

        private SoccerLeagueData MapLineToRecord(string line)
        {
            var properties = line.Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

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
            };

            return record;

        }
    }
}


