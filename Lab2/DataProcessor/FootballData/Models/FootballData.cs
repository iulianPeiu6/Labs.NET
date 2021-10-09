﻿using System;
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
        public int W { get; set; }
        public int L { get; set; }
        public int D { get; set; }
        public int F { get; set; }
        public int A { get; set; }
        public int Pts { get; set; }


        public override string ToString()
        {

            var elements = GetType().GetProperties().ToList().Select(property => property.GetValue(this));



            var toStringResult = string.Join(",", elements);

            return toStringResult;
        }
    }
}