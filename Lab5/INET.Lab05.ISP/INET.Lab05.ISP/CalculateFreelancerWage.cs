using System;
using INET.Lab05.IS.Abstractions;

namespace INET.Lab05.IS
{
    public class CalculateFreelancerWage : ICalculateWage
    {
        public string Benefits()
        {
            return "Free daily coffe at Starbucks for a month";
        }

        public decimal GetBonus()
        {
            throw new NotImplementedException();
        }

        public decimal GetHourlyWage()
        {
            return decimal.Multiply(100, GetRate());
        }

        public decimal GetMonthlyWage()
        {
            throw new NotImplementedException();
        }

        public decimal GetRate()
        {
            return 3.5M;
        }
    }
}
