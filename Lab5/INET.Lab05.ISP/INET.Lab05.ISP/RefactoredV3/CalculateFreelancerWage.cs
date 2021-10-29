using INET.Lab05.ISP.RefactoredV3.Abstractions;

namespace INET.Lab05.ISP.RefactoredV3
{
    class CalculateFreelancerWage : IBenefits,  IGetHourlyWage, IGetRate
    {
        public string Benefits()
        {
            return "Free daily coffe at Starbucks for a month";
        }
        public decimal GetHourlyWage()
        {
            return decimal.Multiply(100, GetRate());
        }
        public decimal GetRate()
        {
            return 3.5M;
        }
    }
}
