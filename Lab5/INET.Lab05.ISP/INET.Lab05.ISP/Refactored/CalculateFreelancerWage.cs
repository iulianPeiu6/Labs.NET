using INET.Lab05.ISP.Refactored.Abstractions;

namespace INET.Lab05.ISP.Refactored
{
    public class CalculateFreelancerWage : ICalculateFreelancerWage
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
