using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
                this.salary = value;
            }
        }
        public Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        protected Employee(string firstName, string lastName, string id, decimal salary, Department department) : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public override string ToString()
        {
            string result = String.Format("{0}, Salary: {1}, Department: {2}",
                base.ToString(), this.Salary, this.Department);
            
            return result;
        }
    }
}
