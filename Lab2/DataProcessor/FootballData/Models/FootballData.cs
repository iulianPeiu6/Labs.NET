using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.FootballData.Models
{
    public class FootballData
    {

        public string Team { get; set; }
        public int P { get; set; }
        public string W { get; set; }
        public string L { get; set; }
        public string D { get; set; }
        public string F { get; set; }
        public string A { get; set; }
        public string Pts { get; set; }


        public override string ToString()
        {

            var elements = GetType().GetProperties().ToList().Select(property => property.GetValue(this));



            var toStringResult = string.Join(",", elements);

            return toStringResult;
        }
    }
}