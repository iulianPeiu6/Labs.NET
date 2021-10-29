using INET.Lab05.ISP.Refactored.Abstractions;

namespace INET.Lab05.ISP.Refactored
{
    public class CalculateFullTimeEmployeeWage : ICalculateFullTimeEmployeeWage
    {
        public string Benefits()
        {
            return "Free meal at Fenice, for 2";
        }

        public decimal GetBonus()
        {
            return decimal.Multiply(GetMonthlyWage(), .2M);
        }

        public decimal GetMonthlyWage()
        {
            return 100;
        }
    }
}
