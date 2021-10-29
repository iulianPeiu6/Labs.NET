using INET.Lab05.ISP.RefactoredV3.Abstractions;

namespace INET.Lab05.ISP.RefactoredV3
{
    class CalculateFullTimeEmployeeWage : IBenefits
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
