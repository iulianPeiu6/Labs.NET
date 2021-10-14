using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data_v2
{
    public class DataReaderBase
    {
        protected List<T> GetLines<T>(string filename, Func<string, T> lineMapper, bool hasHeader = true)
        {
            var records = new List<T>();

            var bulkContent = File.ReadAllText(filename);

            var bulkLines = bulkContent.Split("\n").ToList();

            if (hasHeader)
            {
                bulkLines.RemoveAt(0);
            }

            foreach (var line in bulkLines)
            {
                var mappedRecord = lineMapper(line);
                if (mappedRecord != null)
                {
                    records.Add(mappedRecord);
                }
            }

            return records;
        }
    }
}
