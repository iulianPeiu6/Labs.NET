using Data_v2.Mappings;
using Data_v2.Models;
using System;
using System.Collections.Generic;

namespace Data_v2
{
    public class SoccerLeagueDataReader : DataReaderBase
    {
        public IList<SoccerLeagueData> ReadRecords(string filename, bool hasHeader = true)
        {
            var records = GetLines<SoccerLeagueData>(filename, (string line) => MapLineToRecord(line), hasHeader);

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
