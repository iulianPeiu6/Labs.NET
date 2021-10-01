using Models.Abstracts;

namespace Models
{
    public class Manager : Employee
    {
        public override string Salutation()
        {
            return $"Hello Manager { GetFullName() }";
        }
    }
}
