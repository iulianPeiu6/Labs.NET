using Models.Abstracts;

namespace Models
{
    public class Architect : Employee
    {
        public override string Salutation()
        {
            return $"Hello Architect { GetFullName() }";
        }
    }
}
