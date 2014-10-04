using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Humans
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary 
        {
            get { return this.weekSalary;}
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ivalid Week Salary");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ivalid Week Salary");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / 5 / WorkHoursPerDay;
        }

        public override string ToString()
        {
            return String.Format("Worker: {0} {1}, Week Salary: {2}, Work hours per day: {3}", 
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
