namespace INET.Lab05.IS.Abstractions
{
    interface ICalculateWage
    {
        public decimal GetRate();

        public decimal GetHourlyWage();

        public decimal GetMonthlyWage();

        public decimal GetBonus();

        public string Benefits();
    }
}
