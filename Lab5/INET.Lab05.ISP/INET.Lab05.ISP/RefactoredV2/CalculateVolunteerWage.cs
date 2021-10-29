using INET.Lab05.ISP.RefactoredV2.Abstractions;

namespace INET.Lab05.ISP.RefactoredV2
{
    public class CalculateVolunteerWage : ICalculateVolunteerWage, ICalculateWage
    {
        public string Benefits()
        {
            return "Tickets to Avatar 2 premiere";
        }
    }
}
