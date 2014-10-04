using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;

namespace _04_CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal sumAmount;

        public decimal SumAmount
        {
            get
            {
                return this.sumAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Sum cannot be negative.");
                }
                this.sumAmount = value;
            }
        }

        public Customer(string firstName, string lastName, string id, decimal sumAmount)
            : base(firstName, lastName, id)
        {
            this.SumAmount = sumAmount;
        }

        public override string ToString()
        {
            string result = string.Format("{0}: {1} {2}, ID: {3}, Total amount of money: {4}",
                this.GetType().Name, this.FirstName, this.LastName, this.Id, this.SumAmount);

            return result;
        }
    }
}
