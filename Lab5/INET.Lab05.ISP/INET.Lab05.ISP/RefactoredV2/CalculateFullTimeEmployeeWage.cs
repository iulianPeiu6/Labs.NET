using INET.Lab05.ISP.RefactoredV2.Abstractions;

namespace INET.Lab05.ISP.RefactoredV2
{
    public class CalculateFullTimeEmployeeWage : ICalculateFullTimeEmployeeWage, ICalculateWage
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
