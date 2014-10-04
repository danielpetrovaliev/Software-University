using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy
{
    public class Maneger : Employee, IManeger 
    {
        private IList<Employee> employees;

        public IList<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("Manager must hold a set of employees");
                }
                this.employees = value;
            }
        }

        public Maneger(string firstName, string lastName, string id, decimal salary, 
            Department department, IList<Employee> employees) 
            : base(firstName, lastName, id, salary, department)
        {
            this.Employees = employees;
        }

        public override string ToString()
        {
            string result = String.Format("{0}: {1} Employees: ", 
                this.GetType().Name, base.ToString());

            int counter = 1;
            foreach (var employee in this.Employees)
            {
                result += "\n\n" + counter + ". " + employee.GetType().Name
                    + " : " + employee;

                counter++;
            }

            return result;
        }
    }
}
