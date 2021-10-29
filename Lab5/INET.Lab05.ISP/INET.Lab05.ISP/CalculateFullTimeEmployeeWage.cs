using System;
using INET.Lab05.IS.Abstractions;

namespace INET.Lab05.IS
{
    public class CalculateFullTimeEmployeeWage : ICalculateWage
    {
        public string Benefits()
        {
            return "Free meal at Fenice, for 2";
        }

        public decimal GetBonus()
        {
            return decimal.Multiply(GetMonthlyWage(), .2M);
        }

        public decimal GetHourlyWage()
        {
            throw new NotImplementedException();
        }

        public decimal GetMonthlyWage()
        {
            return 100;
        }

        public decimal GetRate()
        {
            throw new NotImplementedException();
        }
    }
}
