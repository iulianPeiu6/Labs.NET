namespace INET.Lab05.ISP.Refactored.Abstractions
{
    public interface ICalculateFreelancerWage : ICalculateWage
    {
        decimal GetRate();
    }
}