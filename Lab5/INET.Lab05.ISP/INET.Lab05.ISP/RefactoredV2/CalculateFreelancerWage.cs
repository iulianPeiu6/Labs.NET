using INET.Lab05.ISP.RefactoredV2.Abstractions;

namespace INET.Lab05.ISP.RefactoredV2
{
    public class CalculateFreelancerWage : ICalculateFreelancerWage, ICalculateWage
    {
        public string Benefits()
        {
            return "Free daily coffe at Starbucks for a month";
        }

        public decimal GetRate()
        {
            return 3.5M;
        }
    }
}
