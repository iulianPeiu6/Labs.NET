using Data_v2.Models;
using System.Collections.Generic;

namespace Data_v2
{
    public class SoccerLeagueDataProcessor : DataProcessorBase
    {
        public SoccerLeagueData GetRecordWithSmallestDifferenceForAgainstGoals(IList<SoccerLeagueData> records)
        {
            var result = GetRecordWithSmallestSpreadBetween<SoccerLeagueData>(records, nameof(SoccerLeagueData.F), nameof(SoccerLeagueData.A));

            return result;
        }
    }
}


