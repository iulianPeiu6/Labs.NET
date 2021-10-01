using System;

namespace Models.Abstracts
{
    public abstract class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Salary { get; set; }

        public string GetFullName()
        {
            return $"{ FirstName }{ LastName }";
        }

        public bool IsActive()
        {
            if (EndDate > DateTime.Now)
                return true;
            return false;
        }

        /// <summary>
        /// Virtual methods have an implementation and provide the derived classes with the option of overriding it. 
        /// Abstract methods do not provide an implementation and force the derived classes to override the method.
        /// 
        /// We considered that we don't need default implementation for Salutation, this is why we used abstract and not virtual.
        /// The classes that inherit Employee(e.g Architect, Manager) are forced to give an implementation for this method.
        /// </summary>
        /// <returns>a string representing a salutation form for the current employee</returns>
        public abstract string Salutation();
    }
}
