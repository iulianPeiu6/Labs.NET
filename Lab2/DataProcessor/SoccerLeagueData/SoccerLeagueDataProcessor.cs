using Data.Models;
using System.Collections.Generic;
using System.Linq;
using Vanguard;

namespace Data
{
    public class SoccerLeagueDataProcessor
    {
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
    }
}


