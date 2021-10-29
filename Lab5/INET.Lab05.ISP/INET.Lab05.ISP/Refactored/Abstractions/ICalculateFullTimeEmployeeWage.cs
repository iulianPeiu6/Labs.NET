namespace INET.Lab05.ISP.Refactored.Abstractions
{
    public interface ICalculateFullTimeEmployeeWage : ICalculateWage
    {
        decimal GetBonus();
        decimal GetMonthlyWage();
    }
}