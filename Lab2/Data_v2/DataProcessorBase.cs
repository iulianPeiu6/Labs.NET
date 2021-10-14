using System;
using System.Collections.Generic;
using System.Linq;
using Vanguard;

namespace Data_v2
{
    public abstract class DataProcessorBase
    {
        protected T GetRecordWithSmallestSpreadBetween<T>(IList<T> records, string firstField, string secondField)
        {
            Guard.ArgumentNotNullOrEmpty(records, nameof(records));

            var result = records.FirstOrDefault();
            var firstFieldValue = (int)result.GetType().GetProperty(firstField).GetValue(result, null);
            var secondFieldValue = (int)result.GetType().GetProperty(secondField).GetValue(result, null);
            var smallestSpreed = firstFieldValue - secondFieldValue;

            foreach (var record in records)
            {
                firstFieldValue = (int)record.GetType().GetProperty(firstField).GetValue(record, null);
                secondFieldValue = (int)record.GetType().GetProperty(secondField).GetValue(record, null);
                var spread = Math.Abs(firstFieldValue - secondFieldValue);
                if (spread < smallestSpreed)
                {
                    smallestSpreed = spread;
                    result = record;
                }
            }

            return result;
        }
    }
}
