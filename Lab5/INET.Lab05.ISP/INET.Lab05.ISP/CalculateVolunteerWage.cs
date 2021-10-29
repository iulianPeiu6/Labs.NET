using System;
using INET.Lab05.IS.Abstractions;

namespace INET.Lab05.IS
{
    public class CalculateVolunteerWage : ICalculateWage
    {
        public decimal GetBonus()
        {
            throw new NotImplementedException();
        }

        public decimal GetHourlyWage()
        {
            throw new NotImplementedException();
        }

        public decimal GetMonthlyWage()
        {
            throw new NotImplementedException();
        }

        public decimal GetRate()
        {
            throw new NotImplementedException();
        }

        public string Benefits()
        {
            return "Tickets to Avatar 2 premiere";
        }
    }
}
